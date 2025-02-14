namespace ControleMetas.Forms
{
    partial class FrmControleMeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControleMeta));
            botoesTablePanel = new TableLayoutPanel();
            excluirButton = new Button();
            cancelarButton = new Button();
            adicionarButton = new Button();
            editarButton = new Button();
            buscarButton = new Button();
            metasDataGridView = new DataGridView();
            nenhumaMetaLabel = new Label();
            buscarTextBox = new TextBox();
            botoesTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)metasDataGridView).BeginInit();
            SuspendLayout();
            // 
            // botoesTablePanel
            // 
            botoesTablePanel.ColumnCount = 6;
            botoesTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            botoesTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            botoesTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            botoesTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            botoesTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            botoesTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            botoesTablePanel.Controls.Add(excluirButton, 0, 0);
            botoesTablePanel.Controls.Add(cancelarButton, 5, 0);
            botoesTablePanel.Controls.Add(adicionarButton, 4, 0);
            botoesTablePanel.Controls.Add(editarButton, 3, 0);
            botoesTablePanel.Controls.Add(buscarButton, 2, 0);
            botoesTablePanel.Dock = DockStyle.Bottom;
            botoesTablePanel.Location = new Point(0, 815);
            botoesTablePanel.Margin = new Padding(3, 4, 3, 4);
            botoesTablePanel.Name = "botoesTablePanel";
            botoesTablePanel.RowCount = 1;
            botoesTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            botoesTablePanel.Size = new Size(1399, 60);
            botoesTablePanel.TabIndex = 0;
            // 
            // excluirButton
            // 
            excluirButton.Anchor = AnchorStyles.None;
            excluirButton.BackColor = Color.Red;
            excluirButton.Cursor = Cursors.Hand;
            excluirButton.FlatAppearance.BorderColor = Color.White;
            excluirButton.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            excluirButton.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            excluirButton.FlatStyle = FlatStyle.Flat;
            excluirButton.Font = new Font("Montserrat", 12F);
            excluirButton.ForeColor = Color.White;
            excluirButton.Location = new Point(25, 6);
            excluirButton.Margin = new Padding(3, 4, 3, 4);
            excluirButton.MinimumSize = new Size(183, 48);
            excluirButton.Name = "excluirButton";
            excluirButton.Size = new Size(183, 48);
            excluirButton.TabIndex = 4;
            excluirButton.Text = "Excluir (Del)";
            excluirButton.UseVisualStyleBackColor = false;
            excluirButton.Click += ExcluirButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Anchor = AnchorStyles.None;
            cancelarButton.BackColor = Color.Transparent;
            cancelarButton.CausesValidation = false;
            cancelarButton.Cursor = Cursors.Hand;
            cancelarButton.FlatAppearance.BorderColor = Color.White;
            cancelarButton.FlatAppearance.MouseDownBackColor = Color.LightGray;
            cancelarButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            cancelarButton.FlatStyle = FlatStyle.Flat;
            cancelarButton.Font = new Font("Montserrat", 12F);
            cancelarButton.ForeColor = Color.White;
            cancelarButton.Location = new Point(1190, 6);
            cancelarButton.Margin = new Padding(3, 4, 3, 4);
            cancelarButton.MinimumSize = new Size(183, 48);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(183, 48);
            cancelarButton.TabIndex = 2;
            cancelarButton.Text = "< Voltar (Esc)";
            cancelarButton.UseVisualStyleBackColor = false;
            cancelarButton.Click += CancelarButton_Click;
            // 
            // adicionarButton
            // 
            adicionarButton.Anchor = AnchorStyles.None;
            adicionarButton.BackColor = Color.Green;
            adicionarButton.Cursor = Cursors.Hand;
            adicionarButton.FlatAppearance.BorderColor = Color.White;
            adicionarButton.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            adicionarButton.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            adicionarButton.FlatStyle = FlatStyle.Flat;
            adicionarButton.Font = new Font("Montserrat", 12F);
            adicionarButton.ForeColor = Color.White;
            adicionarButton.Location = new Point(957, 6);
            adicionarButton.Margin = new Padding(3, 4, 3, 4);
            adicionarButton.MinimumSize = new Size(183, 48);
            adicionarButton.Name = "adicionarButton";
            adicionarButton.Size = new Size(183, 48);
            adicionarButton.TabIndex = 3;
            adicionarButton.Text = "Adicionar [+] (F2)";
            adicionarButton.UseVisualStyleBackColor = false;
            adicionarButton.Click += AdicionarButton_Click;
            // 
            // editarButton
            // 
            editarButton.Anchor = AnchorStyles.None;
            editarButton.BackColor = Color.DarkGoldenrod;
            editarButton.Cursor = Cursors.Hand;
            editarButton.FlatAppearance.BorderColor = Color.White;
            editarButton.FlatAppearance.MouseDownBackColor = Color.Goldenrod;
            editarButton.FlatAppearance.MouseOverBackColor = Color.Orange;
            editarButton.FlatStyle = FlatStyle.Flat;
            editarButton.Font = new Font("Montserrat", 12F);
            editarButton.ForeColor = Color.White;
            editarButton.Location = new Point(724, 6);
            editarButton.Margin = new Padding(3, 4, 3, 4);
            editarButton.MinimumSize = new Size(183, 48);
            editarButton.Name = "editarButton";
            editarButton.Size = new Size(183, 48);
            editarButton.TabIndex = 5;
            editarButton.Text = "Editar (F3)";
            editarButton.UseVisualStyleBackColor = false;
            editarButton.Click += EditarButton_Click;
            // 
            // buscarButton
            // 
            buscarButton.Anchor = AnchorStyles.None;
            buscarButton.BackColor = Color.DarkCyan;
            buscarButton.Cursor = Cursors.Hand;
            buscarButton.FlatAppearance.BorderColor = Color.White;
            buscarButton.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            buscarButton.FlatAppearance.MouseOverBackColor = Color.Teal;
            buscarButton.FlatStyle = FlatStyle.Flat;
            buscarButton.Font = new Font("Montserrat", 12F);
            buscarButton.ForeColor = Color.White;
            buscarButton.Location = new Point(491, 6);
            buscarButton.Margin = new Padding(3, 4, 3, 4);
            buscarButton.MinimumSize = new Size(183, 48);
            buscarButton.Name = "buscarButton";
            buscarButton.Size = new Size(183, 48);
            buscarButton.TabIndex = 6;
            buscarButton.Text = "Buscar (F11)";
            buscarButton.UseVisualStyleBackColor = false;
            buscarButton.Click += BuscarButton_Click;
            // 
            // metasDataGridView
            // 
            metasDataGridView.BackgroundColor = Color.FromArgb(33, 46, 61);
            metasDataGridView.BorderStyle = BorderStyle.Fixed3D;
            metasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            metasDataGridView.Location = new Point(14, 14);
            metasDataGridView.Margin = new Padding(3, 4, 3, 4);
            metasDataGridView.Name = "metasDataGridView";
            metasDataGridView.Size = new Size(1371, 793);
            metasDataGridView.TabIndex = 1;
            metasDataGridView.CellContentClick += MetasDataGridView_CellContentClick;
            metasDataGridView.CellDoubleClick += MetasDataGridView_CellDoubleClick;
            metasDataGridView.CellFormatting += MetasDataGridView_CellFormatting;
            metasDataGridView.ColumnHeaderMouseClick += MetasDataGridView_ColumnHeaderMouseClick;
            // 
            // nenhumaMetaLabel
            // 
            nenhumaMetaLabel.AutoSize = true;
            nenhumaMetaLabel.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nenhumaMetaLabel.ForeColor = Color.Transparent;
            nenhumaMetaLabel.Location = new Point(474, 372);
            nenhumaMetaLabel.Name = "nenhumaMetaLabel";
            nenhumaMetaLabel.Size = new Size(426, 25);
            nenhumaMetaLabel.TabIndex = 2;
            nenhumaMetaLabel.Text = "Não Existe Nenhuma Meta Cadastrada no Momento";
            nenhumaMetaLabel.Visible = false;
            // 
            // buscarTextBox
            // 
            buscarTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buscarTextBox.Location = new Point(1158, 775);
            buscarTextBox.Name = "buscarTextBox";
            buscarTextBox.PlaceholderText = "Digite para buscar...";
            buscarTextBox.Size = new Size(215, 22);
            buscarTextBox.TabIndex = 3;
            buscarTextBox.Visible = false;
            buscarTextBox.TextChanged += BuscarTextBox_TextChanged;
            // 
            // FrmControleMeta
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 46, 61);
            ClientSize = new Size(1399, 875);
            Controls.Add(buscarTextBox);
            Controls.Add(nenhumaMetaLabel);
            Controls.Add(metasDataGridView);
            Controls.Add(botoesTablePanel);
            Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimumSize = new Size(1415, 914);
            Name = "FrmControleMeta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle das Metas";
            Load += FrmControleMeta_Load;
            KeyDown += FrmControleMeta_KeyDown;
            botoesTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)metasDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel botoesTablePanel;
        private DataGridView metasDataGridView;
        private Button cancelarButton;
        private Label nenhumaMetaLabel;
        private Button adicionarButton;
        private Button excluirButton;
        private Button editarButton;
        private Button buscarButton;
        private TextBox buscarTextBox;
    }
}