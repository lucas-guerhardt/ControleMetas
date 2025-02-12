using System;
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
using ControleMetas.Utils.FormatUtils;

namespace ControleMetas.Forms
{
    public partial class FrmCadastroMeta : Form
    {
        private VendedorController VendedorController = new();

        private MetaController MetaController = new();

        public FrmCadastroMeta()
        {
            InitializeComponent();
        }

        private void FrmCadastroMeta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FrmCadastroMeta_Load(object sender, EventArgs e)
        {
            Data.GerarVendedores();

            var listaVendedores = VendedorController.Get();
            Debug.WriteLine($"Total de vendedores: {listaVendedores.Count}");

            foreach (var vendedor in listaVendedores)
            {
                Debug.WriteLine($"Vendedor: {vendedor.Nome}");
            }

            formatoComboBox.DataSource = Enum.GetValues(typeof(FormatoMetaEnum));

            periodicidadeComboBox.DataSource = Enum.GetValues(typeof(PeriodicidadeMetaEnum));

            vendedorComboBox.DataSource = listaVendedores;
            vendedorComboBox.DisplayMember = "Nome";
        }

        private void CadastroTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void AdicionarButton_Click(object sender, EventArgs e)
        {
                var novaMeta = new MetaModel
                {
                    Nome = nomeMetaTextBox.Text,
                    Vendedor = vendedorComboBox.Text,
                    Formato = (FormatoMetaEnum)Enum.Parse(typeof(FormatoMetaEnum), formatoComboBox.Text),
                    Categoria = (CategoriaMetaEnum)Enum.Parse(typeof(CategoriaMetaEnum), categoriaComboBox.Text),
                    Periodicidade = (PeriodicidadeMetaEnum)Enum.Parse(typeof(PeriodicidadeMetaEnum), periodicidadeComboBox.Text),
                    Valor = decimal.Parse(new string(valorTextBox.Text.Where(c => char.IsDigit(c)).ToArray()))
                };

            try
            {
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
                if (string.IsNullOrEmpty(valorTextBox.Text)) return;

                valorTextBox.BackColor = Color.White;

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
            catch (NotFoundException ex)
            {
                valorTextBox.BackColor = Color.FromArgb(252, 199, 194);
                FormatUtils.FormatarErroLabel(errorLabel, ex.Message);
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
            }
            else
            {
                categoriaComboBox.DataSource = Enum.GetValues(typeof(CategoriaMetaEnum));
            }
        }

    }
}
