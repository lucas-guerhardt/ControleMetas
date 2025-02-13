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
using ControleMetas.Models;

namespace ControleMetas.Forms
{
    public partial class FrmControleMeta : Form
    {
        private MetaController MetaController = MetaController.Instance;

        List<MetaModel> metas;

        private BindingList<MetaModel> bindingList;

        public FrmControleMeta()
        {
            InitializeComponent();
            metas = MetaController.Get();
            bindingList = new BindingList<MetaModel>(metas);

        }

        private void FrmControleMeta_Load(object sender, EventArgs e)
        {
            CarregarMetas();
            this.KeyPreview = true;
            nenhumaMetaLabel.Left = (metasDataGridView.Width - nenhumaMetaLabel.Width) / 2;
            nenhumaMetaLabel.Top = (metasDataGridView.Height - nenhumaMetaLabel.Height) / 2;
        }

        private void FrmControleMeta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void MetasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CarregarMetas()
        {
            if (metas == null || metas.Count == 0)
            {
                nenhumaMetaLabel.Visible = true;
                return;
            }

            nenhumaMetaLabel.Visible = false;

            metasDataGridView.AutoGenerateColumns = true;
            metasDataGridView.AutoResizeColumns();
            metasDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            metasDataGridView.DataSource = bindingList;
        }

        private void AtualizaMetas()
        {
            metas = MetaController.Get();

            if (metas == null || metas.Count == 0)
            {
                nenhumaMetaLabel.Visible = true;
                return;
            }

            nenhumaMetaLabel.Visible = false;

            if (bindingList.Count > 0)
                bindingList.Clear();
              
            Debug.WriteLine("Atualizando metas:");
            foreach (var meta in metas)
            {
                Debug.WriteLine(meta.Nome);
                bindingList.Add(meta);
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {

        }

        private void AdicionarButton_Click(object sender, EventArgs e)
        {
            FrmCadastroMeta frmCadastroMeta = new();
            frmCadastroMeta.ShowDialog();
            AtualizaMetas();
        }
    }
}
