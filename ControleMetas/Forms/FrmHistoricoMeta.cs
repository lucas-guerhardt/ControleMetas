using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleMetas.Controllers;
using ControleMetas.Models;
using ControleMetas.Utils.Data;

namespace ControleMetas.Forms
{
    public partial class FrmHistoricoMeta : Form
    {
        private readonly HistoricoController _historicoController = HistoricoController.Instance;
        public FrmHistoricoMeta()
        {
            InitializeComponent();
        }

        private void FrmHistoricoMeta_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            historicoDataGridView.AutoGenerateColumns = true;
            historicoDataGridView.ReadOnly = true;
            historicoDataGridView.AllowUserToAddRows = false; 
            historicoDataGridView.AllowUserToDeleteRows = false; 
            historicoDataGridView.AllowUserToResizeRows = false; 
            historicoDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
            historicoDataGridView.MultiSelect = false; 
            historicoDataGridView.RowHeadersVisible = false; 
            historicoDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            historicoDataGridView.AutoResizeColumns();

            historicoDataGridView.Columns.Cast<DataGridViewColumn>().ToList()
                .ForEach(col => col.SortMode = DataGridViewColumnSortMode.NotSortable);

            if (historicoDataGridView.Columns["Id"] != null)
            {
                historicoDataGridView.Columns["Id"].Visible = false;
            }

            AtualizaHistorico();
        }

        private void AtualizaHistorico()
        {
            var historico = _historicoController.Get();

            if (historico == null || historico.Count == 0)
            {
                historicoDataGridView.DataSource = null;
                return;
            }

            var historicoOrdenado = historico.OrderByDescending(h=> h.Data).ToList();

            historicoDataGridView.DataSource = new BindingList<HistoricoModel>(historicoOrdenado);
        }
    }
}
