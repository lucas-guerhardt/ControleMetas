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
using ControleMetas.Utils.Data;
using ControleMetas.Utils.FontUtils;

namespace ControleMetas.Forms
{
    public partial class FrmControleMeta : Form
    {
        private readonly MetaController MetaController = MetaController.Instance;

        List<MetaModel> metas;

        private BindingList<MetaModel> bindingList;

        public FrmControleMeta()
        {
            InitializeComponent();

            Font? montserratFont = FontUtils.LoadMontserrat(12);
            if (montserratFont != null)
            {
                this.Font = montserratFont;
            }

            metas = MetaController.Get();
            bindingList = new BindingList<MetaModel>(metas);

        }

        private void FrmControleMeta_Load(object sender, EventArgs e)
        {
            Data.GerarVendedores();
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
            metasDataGridView.Columns.Cast<DataGridViewColumn>().ToList().ForEach(col => col.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        private void FrmControleMeta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                var confirmation = MessageBox.Show("Você Deseja Sair da Aplicação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)
                    this.Close();
            }

            if (e.KeyCode == Keys.F2)
            {
                AdicionarButton_Click(sender, e);
            }

            if (e.KeyCode == Keys.Delete)
            {
                ExcluirButton_Click(sender, e);
            }

            if (e.KeyCode == Keys.F3)
            {
                EditarButton_Click(sender, e);
            }

            if(e.KeyCode == Keys.F11)
            {
                BuscarButton_Click(sender, e);
            }
        }

        private void MetasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MetasDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                metasDataGridView.ClearSelection();
                metasDataGridView.Rows[e.RowIndex].Selected = true;

                EditarButton_Click(sender, e);
            }
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
            if (e.RowIndex % 2 == 0)
            {
                metasDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(202, 215, 229);
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
                            e.Value = $"{valor:F2} Unidades";
                            break;
                        default:
                            e.Value = valor;
                            break;
                    }

                    e.FormattingApplied = true;
                }
            }
        }

        private BindingSource bindingSource = new BindingSource();

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

            bindingSource.DataSource = metas;

            metasDataGridView.DataSource = bindingSource;
            metasDataGridView.Refresh();
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

                string mensagem = selected.Count > 1 ? $"{selected.Count} Metas" : $"{selected.Count} Meta";

                var confirmacao = MessageBox.Show($"Deseja realmente excluir as metas selecionadas? ({mensagem})", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacao == DialogResult.No) return;

                foreach (DataGridViewRow row in selected)
                {
                    string? metaId = row.Cells["Id"].Value.ToString();

                    if (metaId == null) continue;

                    var sucesso = MetaController.Delete(metaId);

                    if (sucesso == null)
                    {
                        MessageBox.Show($"Erro ao excluir meta com ID {metaId}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void EditarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = metasDataGridView.SelectedRows;

                if (metasDataGridView.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Selecione exatamente uma meta para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = metasDataGridView.SelectedRows[0];
                string? id = selectedRow.Cells["Id"].Value as string;

                if (string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("Meta inválida para edição.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var meta = MetaController.Get(id);
                if (meta == null)
                {
                    MessageBox.Show($"Meta com ID {id} não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (FrmEditarMeta frmEditarMeta = new(meta))
                {
                    frmEditarMeta.ShowDialog();
                }

                AtualizaMetas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao Editar Meta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if(buscarTextBox.Visible)
            {
                buscarTextBox.Visible = false;
                buscarTextBox.Text = string.Empty;
                return;
            }

            buscarTextBox.Visible = true;
            buscarTextBox.Focus();
        }

        private void BuscarTextBox_TextChanged(object sender, EventArgs e)
        {
            if (metas == null) return;

            string filtro = buscarTextBox.Text.Trim().ToLower();

            if(string.IsNullOrEmpty(filtro))
            {
                metasDataGridView.DataSource = bindingList;
            }
            else
            {
                var metasFiltradas = metas
                    .Where(m => m.Nome.ToLower().Contains(filtro) || m.Vendedor.ToLower().Contains(filtro))
                    .ToList();

                metasDataGridView.DataSource = new BindingList<MetaModel>(metasFiltradas);
            }
        }
    }
}
