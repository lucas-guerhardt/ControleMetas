﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleMetas.Controllers;
using ControleMetas.Exceptions;
using ControleMetas.Models;
using ControleMetas.Models.Enum;
using ControleMetas.Utils.Data;
using ControleMetas.Utils.FontUtils;
using ControleMetas.Utils.FormatUtils;

namespace ControleMetas.Forms
{
    public partial class FrmCadastroMeta : Form
    {
        private readonly VendedorController VendedorController = new();

        private readonly MetaController MetaController = MetaController.Instance;

        public FrmCadastroMeta()
        {
            InitializeComponent();

            Font? montserratFont = FontUtils.LoadMontserrat(12);
            if (montserratFont != null)
            {
                this.Font = montserratFont;
            }
        }

        private void FrmCadastroMeta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if(e.KeyCode == Keys.F2)
            {
                AdicionarButton_Click(sender, e);
            }
        }

        private void FrmCadastroMeta_Load(object sender, EventArgs e)
        {
            var listaVendedores = VendedorController.Get();

            formatoComboBox.DataSource = Enum.GetValues(typeof(FormatoMetaEnum));

            periodicidadeComboBox.DataSource = Enum.GetValues(typeof(PeriodicidadeMetaEnum));

            vendedorComboBox.DataSource = listaVendedores;
            vendedorComboBox.DisplayMember = "Nome";

            formatoComboBox.MouseWheel += ComboBox_MouseWheel;
            categoriaComboBox.MouseWheel += ComboBox_MouseWheel;
            vendedorComboBox.MouseWheel += ComboBox_MouseWheel;
            periodicidadeComboBox.MouseWheel += ComboBox_MouseWheel;
        }

        private void CadastroTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ComboBox_MouseWheel(object? sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void NomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void NomeMetaTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nomeMetaTextBox.Text)) throw new BusinessException("O nome não deve ser nulo.");
                nomeMetaTextBox.BackColor = Color.White;
            }
            catch (BusinessException ex)
            {
                nomeMetaTextBox.BackColor = Color.FromArgb(252, 199, 194);
                FormatUtils.FormatarErroLabel(errorLabel, ex.Message);
            }
        }

        private void AdicionarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(nomeMetaTextBox.Text)) throw new BusinessException("O nome não deve ser nulo.");

                if (string.IsNullOrEmpty(valorTextBox.Text)) throw new BusinessException("O valor não deve ser nulo.");

                var novaMeta = new MetaModel
                {
                    Nome = nomeMetaTextBox.Text,
                    Vendedor = vendedorComboBox.Text,
                    Formato = (FormatoMetaEnum)Enum.Parse(typeof(FormatoMetaEnum), formatoComboBox.Text),
                    Categoria = (CategoriaMetaEnum)Enum.Parse(typeof(CategoriaMetaEnum), categoriaComboBox.Text),
                    Periodicidade = (PeriodicidadeMetaEnum)Enum.Parse(typeof(PeriodicidadeMetaEnum), periodicidadeComboBox.Text),
                    Valor = decimal.Parse(new string(valorTextBox.Text.Where(c => char.IsDigit(c)).ToArray()))
                };

                if (novaMeta.Valor <= 0) throw new BusinessException("O valor deve ser maior que zero.");

                if (!char.IsLetter(novaMeta.Nome[0])) throw new BusinessException("O nome deve começar com uma letra.");



                MetaController.Create(novaMeta);
                MessageBox.Show("Meta criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao criar nova meta.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotoesTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ValorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                valorTextBox.BackColor = Color.White;

                if (string.IsNullOrEmpty(valorTextBox.Text)) throw new BusinessException("O valor não deve ser nulo.");

                string? formatoSelecionado = formatoComboBox.GetItemText(formatoComboBox.SelectedItem);

                string valorSemFormatacao = new(valorTextBox.Text.Where(char.IsDigit).ToArray());

                valorTextBox.Text = FormatUtils.FormatarValor(valorSemFormatacao, formatoSelecionado);

                if (formatoSelecionado == "Litros")
                    valorTextBox.SelectionStart = valorTextBox.Text.Length - 2;
                else if (formatoSelecionado == "Monetario")
                    valorTextBox.SelectionStart = valorTextBox.Text.Length;
                else
                    valorTextBox.SelectionStart = valorTextBox.Text.Length - 3;
            }
            catch (Exception ex)
            {
                valorTextBox.BackColor = Color.FromArgb(252, 199, 194);
                FormatUtils.FormatarErroLabel(errorLabel, ex.Message);
            }
        }

        private void ValorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char) Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void ValorTextBox_Enter(object sender, EventArgs e)
        {
            try
            {
                if (valorTextBox.Text == string.Empty) return;

                string? formatoSelecionado = formatoComboBox.GetItemText(formatoComboBox.SelectedItem);

                string valorSemFormatacao = new(valorTextBox.Text.Where(char.IsDigit).ToArray());

                valorTextBox.Text = FormatUtils.FormatarValor(valorSemFormatacao, formatoSelecionado);

                valorTextBox.SelectionStart = valorTextBox.Text.Length;

            }
            catch (NotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ValorTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (valorTextBox.Text == string.Empty) return;

                string? formatoSelecionado = formatoComboBox.GetItemText(formatoComboBox.SelectedItem);

                string valorSemFormatacao = new(valorTextBox.Text.Where(char.IsDigit).ToArray());

                valorTextBox.Text = FormatUtils.FormatarValor(valorSemFormatacao, formatoSelecionado);

                valorTextBox.SelectionStart = valorTextBox.Text.Length - 2;

            }
            catch (NotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CategoriaLabel_Click(object sender, EventArgs e)
        {

        }

        private void PeriodicidadeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormatoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? formatoSelecionado = formatoComboBox.GetItemText(formatoComboBox.SelectedItem);

            if (formatoSelecionado == "Litros")
            {
                categoriaComboBox.DataSource = Enum.GetValues(typeof(CategoriaMetaEnum)).Cast<CategoriaMetaEnum>().Where(c => c == CategoriaMetaEnum.Barris || c == CategoriaMetaEnum.Garrafas).ToList();
                valorTextBox.Text = "0,00 L";
            }
            else
            {
                categoriaComboBox.DataSource = Enum.GetValues(typeof(CategoriaMetaEnum));
            }

            if (formatoSelecionado == "Monetario")
            {
                valorTextBox.Text = "R$ 0,00";
            }
            else
            {
                valorTextBox.Text = "0,00 UN";
            }
        }

    }
}
