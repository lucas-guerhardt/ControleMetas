namespace ControleMetas.Forms
{
    partial class FrmHistoricoMeta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistoricoMeta));
            historicoDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)historicoDataGridView).BeginInit();
            SuspendLayout();
            // 
            // historicoDataGridView
            // 
            historicoDataGridView.BackgroundColor = Color.FromArgb(33, 46, 61);
            historicoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            historicoDataGridView.Dock = DockStyle.Fill;
            historicoDataGridView.Location = new Point(0, 0);
            historicoDataGridView.Name = "historicoDataGridView";
            historicoDataGridView.Size = new Size(784, 561);
            historicoDataGridView.TabIndex = 0;
            // 
            // FrmHistoricoMeta
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 46, 61);
            ClientSize = new Size(784, 561);
            Controls.Add(historicoDataGridView);
            Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "FrmHistoricoMeta";
            Text = "Histórico de Operações em Metas";
            Load += FrmHistoricoMeta_Load;
            ((System.ComponentModel.ISupportInitialize)historicoDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView historicoDataGridView;
    }
}