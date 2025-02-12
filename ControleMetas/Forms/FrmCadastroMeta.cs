using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleMetas.Forms
{
    public partial class FrmCadastroMeta : Form
    {
        public FrmCadastroMeta()
        {
            InitializeComponent();
        }

        private void FrmCadastroMeta_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void label1_Click_5(object sender, EventArgs e)
        {

        }

        private void label1_Click_6(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cadastroTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void adicionarButton_Click(object sender, EventArgs e)
        {

        }

        private void botoesTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void valorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(valorTextBox.Text)) return;

            string valorSemFormatacao = new string(valorTextBox.Text.Where(char.IsDigit).ToArray());

            if (decimal.TryParse(valorSemFormatacao, out decimal valor))
            {
                valor /= 100;
                valorTextBox.Text = valor.ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("pt-BR"));
                valorTextBox.SelectionStart = valorTextBox.Text.Length;
            }
        }

        private void valorTextBox_Leave(object sender, EventArgs e)
        {
            if (valorTextBox.Text == string.Empty) return;
            if (decimal.TryParse(valorTextBox.Text, out decimal valor))
            {
                valorTextBox.Text = valor.ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("pt-BR"));
            }
        }
    }
}
