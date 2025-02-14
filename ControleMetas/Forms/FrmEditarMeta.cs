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
using ControleMetas.Utils.FontUtils;
using ControleMetas.Utils.FormatUtils;

namespace ControleMetas.Forms
{
    public partial class FrmEditarMeta : Form
    {
        private readonly VendedorController VendedorController = new();

        private readonly MetaController MetaController = MetaController.Instance;

        public FrmEditarMeta(MetaModel meta)
        {
            InitializeComponent();

            Font? montserratFont = FontUtils.LoadMontserrat(12);
            if (montserratFont != null)
            {
                this.Font = montserratFont;
            }

            idValueLabel.Text = meta.Id;
            nomeTextBox.Text = meta.Nome;

            vendedorComboBox.DataSource = VendedorController.Get();
            vendedorComboBox.DisplayMember = "Nome";
            vendedorComboBox.SelectedItem = vendedorComboBox.Items.Cast<VendedorModel>().FirstOrDefault(v => v.Nome == meta.Vendedor);

            formatoComboBox.DataSource = Enum.GetValues(typeof(FormatoMetaEnum));
            formatoComboBox.SelectedItem = meta.Formato;

            categoriaComboBox.DataSource = Enum.GetValues(typeof(CategoriaMetaEnum));
            categoriaComboBox.SelectedItem = meta.Categoria;

            periodicidadeComboBox.DataSource = Enum.GetValues(typeof(PeriodicidadeMetaEnum));
            periodicidadeComboBox.SelectedItem = meta.Periodicidade;

            valorTextBox.Text = $"{meta.Valor:N2} {ObterUnidade(meta.Formato)}";

            errorLabel.Location = new Point(errorLabel.Location.X, errorLabel.Location.Y + 20);
        }
        private static string ObterUnidade(FormatoMetaEnum formato)
        {
            return formato switch
            {
                FormatoMetaEnum.Monetario => "R$",
                FormatoMetaEnum.Litros => "L",
                FormatoMetaEnum.Unidades => "UN",
                _ => ""
            };
        }

        private void FrmEditarMeta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.F2)
            {
                SalvarButton_Click(sender, e);
            }

            if (e.KeyCode == Keys.Delete)
            {
                ExcluirButton_Click(sender, e);
            }
        }

        private void FrmEditarMeta_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            formatoComboBox.MouseWheel += ComboBox_MouseWheel;
            categoriaComboBox.MouseWheel += ComboBox_MouseWheel;
            vendedorComboBox.MouseWheel += ComboBox_MouseWheel;
            periodicidadeComboBox.MouseWheel += ComboBox_MouseWheel;
        }

        private void ComboBox_MouseWheel(object? sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void NomeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nomeTextBox.Text)) throw new BusinessException("O nome não deve ser nulo.");
                nomeTextBox.BackColor = Color.White;
            }
            catch (BusinessException ex)
            {
                nomeTextBox.BackColor = Color.FromArgb(252, 199, 194);
                FormatUtils.FormatarErroLabel(errorLabel, ex.Message);
            }
        }

        private void SalvarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nomeTextBox.Text)) throw new BusinessException("O nome não deve ser nulo.");

                if (string.IsNullOrEmpty(valorTextBox.Text)) throw new BusinessException("O valor não deve ser nulo.");

                var id = idValueLabel.Text;

                var metaAtualizada = new MetaModel
                {
                    Nome = nomeTextBox.Text,
                    Vendedor = vendedorComboBox.Text,
                    Formato = (FormatoMetaEnum)Enum.Parse(typeof(FormatoMetaEnum), formatoComboBox.Text),
                    Categoria = (CategoriaMetaEnum)Enum.Parse(typeof(CategoriaMetaEnum), categoriaComboBox.Text),
                    Periodicidade = (PeriodicidadeMetaEnum)Enum.Parse(typeof(PeriodicidadeMetaEnum), periodicidadeComboBox.Text),
                    Valor = decimal.Parse(new string(valorTextBox.Text.Where(c => char.IsDigit(c)).ToArray()))/100
                };

                if (metaAtualizada.Valor <= 0) throw new BusinessException("O valor deve ser maior que zero.");

                if (!char.IsLetter(metaAtualizada.Nome[0])) throw new BusinessException("O nome deve começar com uma letra.");

                MetaController.Update(id, metaAtualizada);

                MessageBox.Show("Meta atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao atualizar a meta.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
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
            var confirmacao = MessageBox.Show("Existem dados e informações não salvas. Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.No) return;

            this.Close();
        }

        private void FormatoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? formatoSelecionado = formatoComboBox.GetItemText(formatoComboBox.SelectedItem);

            if (formatoSelecionado == "Litros")
            {
                categoriaComboBox.DataSource = Enum.GetValues(typeof(CategoriaMetaEnum)).Cast<CategoriaMetaEnum>().Where(c => c == CategoriaMetaEnum.Barris || c == CategoriaMetaEnum.Garrafas).ToList();
                valorTextBox.Text = $"{valorTextBox.Text} L";
            }
            else
            {
                categoriaComboBox.DataSource = Enum.GetValues(typeof(CategoriaMetaEnum));
            }

            if (formatoSelecionado == "Monetario")
            {
                valorTextBox.Text = $"R$ {valorTextBox.Text}";
            }
            else
            {
                valorTextBox.Text = $"{valorTextBox.Text} UN";
            }
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            try
            {
                var id = idValueLabel.Text;
                var meta = MetaController.Get(id) ?? throw new Exception("Meta não encontrada.");

                var confirmacao = MessageBox.Show($"Deseja realmente excluir a meta {meta.Nome}?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacao == DialogResult.No) return;

                MetaController.Delete(id);

                MessageBox.Show("Meta excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao Excluir Meta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
