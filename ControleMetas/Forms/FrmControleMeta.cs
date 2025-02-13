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

            metasDataGridView.AutoGenerateColumns = true;
            metasDataGridView.AutoResizeColumns();
            metasDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            metasDataGridView.DataSource = bindingList;
            metasDataGridView.ReadOnly = true;
            metasDataGridView.AllowUserToAddRows = false;
        }

        private void FrmControleMeta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if(e.KeyCode == Keys.F2)
            {
                AdicionarButton_Click(sender, e);
            }

            if (e.KeyCode == Keys.Delete)
            {
                ExcluirButton_Click(sender, e);
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
                metasDataGridView.Visible = false;
                return;
            }
            nenhumaMetaLabel.Visible = false;

            metasDataGridView.Visible = true;
            
        }

        private void MetasDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.RowIndex%2 == 0)
            {
                metasDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(202,215,229);
            }

            if (metasDataGridView.Columns[e.ColumnIndex].Name == "Valor")
            {
                var formato = metasDataGridView.Rows[e.RowIndex].Cells["Formato"].Value?.ToString();

                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal valor))
                {
                    switch (formato)
                    {
                        case "Monetario":
                            e.Value = $"R$ {valor:F2}";
                            break;
                        case "Litros":
                            e.Value = $"{valor:F2} Litros";
                            break;
                        case "Unidades":
                            e.Value = $"{valor:F0} Unidades";
                            break;
                    }

                    e.FormattingApplied = true;
                }
            }
        }

        private void AtualizaMetas()
        {
            metas = MetaController.Get();

            if (metas == null || metas.Count == 0)
            {
                nenhumaMetaLabel.Visible = true;
                metasDataGridView.Visible = false;
                return;
            }

            nenhumaMetaLabel.Visible = false;
            metasDataGridView.Visible = true;

            if (bindingList.Count > 0)
                bindingList.Clear();
              
            foreach (var meta in metas)
            {
                bindingList.Add(meta);
            }

            metasDataGridView.Visible = true;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = metasDataGridView.SelectedRows;
                if (selected.Count == 0) throw new Exception("Nenhuma meta selecionada.");

                foreach (DataGridViewRow row in selected)
                {
                    string? metaId = row.Cells["Id"].Value.ToString();

                    if (metaId == null) continue;

                    MetaController.Delete(metaId);
                }

                AtualizaMetas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao Excluir Meta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdicionarButton_Click(object sender, EventArgs e)
        {
            FrmCadastroMeta frmCadastroMeta = new();
            frmCadastroMeta.ShowDialog();
            AtualizaMetas();
        }
    }
}
