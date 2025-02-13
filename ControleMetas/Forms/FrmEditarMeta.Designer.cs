namespace ControleMetas.Forms
{
    partial class FrmEditarMeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarMeta));
            errorLabel = new Label();
            botoesTableLayoutPanel = new TableLayoutPanel();
            salvarButton = new Button();
            cancelarButton = new Button();
            excluirButton = new Button();
            cadastrarMetaGroupBox = new GroupBox();
            editarTableLayoutPanel = new TableLayoutPanel();
            idValueLabel = new Label();
            idLabel = new Label();
            periodicidadeLabel = new Label();
            periodicidadeComboBox = new ComboBox();
            valorLabel = new Label();
            valorTextBox = new TextBox();
            vendedorLabel = new Label();
            vendedorComboBox = new ComboBox();
            categoriaLabel = new Label();
            categoriaComboBox = new ComboBox();
            formatoLabel = new Label();
            formatoComboBox = new ComboBox();
            nomeTextBox = new TextBox();
            nomeLabel = new Label();
            botoesTableLayoutPanel.SuspendLayout();
            cadastrarMetaGroupBox.SuspendLayout();
            editarTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Location = new Point(20, 230);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 15);
            errorLabel.TabIndex = 6;
            // 
            // botoesTableLayoutPanel
            // 
            botoesTableLayoutPanel.ColumnCount = 3;
            botoesTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            botoesTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            botoesTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            botoesTableLayoutPanel.Controls.Add(salvarButton, 2, 0);
            botoesTableLayoutPanel.Controls.Add(cancelarButton, 1, 0);
            botoesTableLayoutPanel.Controls.Add(excluirButton, 0, 0);
            botoesTableLayoutPanel.Dock = DockStyle.Bottom;
            botoesTableLayoutPanel.Location = new Point(0, 260);
            botoesTableLayoutPanel.Name = "botoesTableLayoutPanel";
            botoesTableLayoutPanel.RowCount = 1;
            botoesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            botoesTableLayoutPanel.Size = new Size(384, 56);
            botoesTableLayoutPanel.TabIndex = 5;
            // 
            // salvarButton
            // 
            salvarButton.BackColor = Color.DarkGoldenrod;
            salvarButton.Cursor = Cursors.Hand;
            salvarButton.FlatAppearance.BorderColor = Color.White;
            salvarButton.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            salvarButton.FlatAppearance.MouseOverBackColor = Color.Orange;
            salvarButton.FlatStyle = FlatStyle.Flat;
            salvarButton.Font = new Font("Segoe UI", 12F);
            salvarButton.ForeColor = Color.White;
            salvarButton.Location = new Point(259, 3);
            salvarButton.MinimumSize = new Size(115, 32);
            salvarButton.Name = "salvarButton";
            salvarButton.Size = new Size(115, 32);
            salvarButton.TabIndex = 0;
            salvarButton.Text = "Salvar (F2)";
            salvarButton.UseVisualStyleBackColor = false;
            salvarButton.Click += SalvarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.BackColor = Color.Transparent;
            cancelarButton.CausesValidation = false;
            cancelarButton.Cursor = Cursors.Hand;
            cancelarButton.FlatAppearance.BorderColor = Color.White;
            cancelarButton.FlatAppearance.MouseDownBackColor = Color.LightGray;
            cancelarButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            cancelarButton.FlatStyle = FlatStyle.Flat;
            cancelarButton.Font = new Font("Segoe UI", 12F);
            cancelarButton.ForeColor = Color.White;
            cancelarButton.Location = new Point(131, 3);
            cancelarButton.MinimumSize = new Size(115, 32);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(115, 32);
            cancelarButton.TabIndex = 1;
            cancelarButton.Text = "< Voltar (Esc)";
            cancelarButton.UseVisualStyleBackColor = false;
            cancelarButton.Click += CancelarButton_Click;
            // 
            // excluirButton
            // 
            excluirButton.BackColor = Color.Red;
            excluirButton.Cursor = Cursors.Hand;
            excluirButton.FlatAppearance.BorderColor = Color.White;
            excluirButton.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            excluirButton.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            excluirButton.FlatStyle = FlatStyle.Flat;
            excluirButton.Font = new Font("Segoe UI", 12F);
            excluirButton.ForeColor = Color.White;
            excluirButton.Location = new Point(3, 3);
            excluirButton.MinimumSize = new Size(115, 32);
            excluirButton.Name = "excluirButton";
            excluirButton.Size = new Size(115, 32);
            excluirButton.TabIndex = 5;
            excluirButton.Text = "Excluir (Del)";
            excluirButton.UseVisualStyleBackColor = false;
            excluirButton.Click += ExcluirButton_Click;
            // 
            // cadastrarMetaGroupBox
            // 
            cadastrarMetaGroupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cadastrarMetaGroupBox.Controls.Add(editarTableLayoutPanel);
            cadastrarMetaGroupBox.Font = new Font("Segoe UI", 9F);
            cadastrarMetaGroupBox.ForeColor = Color.White;
            cadastrarMetaGroupBox.Location = new Point(12, 7);
            cadastrarMetaGroupBox.Name = "cadastrarMetaGroupBox";
            cadastrarMetaGroupBox.Size = new Size(363, 238);
            cadastrarMetaGroupBox.TabIndex = 4;
            cadastrarMetaGroupBox.TabStop = false;
            cadastrarMetaGroupBox.Text = "[+] Adicionar Nova Meta";
            // 
            // editarTableLayoutPanel
            // 
            editarTableLayoutPanel.AutoSize = true;
            editarTableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            editarTableLayoutPanel.ColumnCount = 2;
            editarTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            editarTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            editarTableLayoutPanel.Controls.Add(idValueLabel, 1, 0);
            editarTableLayoutPanel.Controls.Add(idLabel, 0, 0);
            editarTableLayoutPanel.Controls.Add(periodicidadeLabel, 0, 6);
            editarTableLayoutPanel.Controls.Add(periodicidadeComboBox, 1, 6);
            editarTableLayoutPanel.Controls.Add(valorLabel, 0, 5);
            editarTableLayoutPanel.Controls.Add(valorTextBox, 1, 5);
            editarTableLayoutPanel.Controls.Add(vendedorLabel, 0, 4);
            editarTableLayoutPanel.Controls.Add(vendedorComboBox, 1, 4);
            editarTableLayoutPanel.Controls.Add(categoriaLabel, 0, 3);
            editarTableLayoutPanel.Controls.Add(categoriaComboBox, 1, 3);
            editarTableLayoutPanel.Controls.Add(formatoLabel, 0, 2);
            editarTableLayoutPanel.Controls.Add(formatoComboBox, 1, 2);
            editarTableLayoutPanel.Controls.Add(nomeTextBox, 1, 1);
            editarTableLayoutPanel.Controls.Add(nomeLabel, 0, 1);
            editarTableLayoutPanel.Location = new Point(3, 19);
            editarTableLayoutPanel.Name = "editarTableLayoutPanel";
            editarTableLayoutPanel.Padding = new Padding(3);
            editarTableLayoutPanel.RowCount = 7;
            editarTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            editarTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            editarTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            editarTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            editarTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            editarTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            editarTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            editarTableLayoutPanel.Size = new Size(340, 209);
            editarTableLayoutPanel.TabIndex = 2;
            // 
            // idValueLabel
            // 
            idValueLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            idValueLabel.AutoSize = true;
            idValueLabel.ForeColor = Color.White;
            idValueLabel.Location = new Point(102, 17);
            idValueLabel.Margin = new Padding(0);
            idValueLabel.Name = "idValueLabel";
            idValueLabel.RightToLeft = RightToLeft.No;
            idValueLabel.Size = new Size(45, 15);
            idValueLabel.TabIndex = 14;
            idValueLabel.Text = "IdValue";
            idValueLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // idLabel
            // 
            idLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            idLabel.AutoSize = true;
            idLabel.ForeColor = Color.Yellow;
            idLabel.Location = new Point(85, 17);
            idLabel.Margin = new Padding(0);
            idLabel.Name = "idLabel";
            idLabel.RightToLeft = RightToLeft.No;
            idLabel.Size = new Size(17, 15);
            idLabel.TabIndex = 13;
            idLabel.Text = "Id";
            idLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // periodicidadeLabel
            // 
            periodicidadeLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            periodicidadeLabel.AutoSize = true;
            periodicidadeLabel.ForeColor = Color.Yellow;
            periodicidadeLabel.Location = new Point(20, 191);
            periodicidadeLabel.Name = "periodicidadeLabel";
            periodicidadeLabel.Size = new Size(79, 15);
            periodicidadeLabel.TabIndex = 11;
            periodicidadeLabel.Text = "Periodicidade";
            periodicidadeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // periodicidadeComboBox
            // 
            periodicidadeComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            periodicidadeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            periodicidadeComboBox.ForeColor = Color.Black;
            periodicidadeComboBox.FormattingEnabled = true;
            periodicidadeComboBox.Location = new Point(105, 180);
            periodicidadeComboBox.Name = "periodicidadeComboBox";
            periodicidadeComboBox.Size = new Size(229, 23);
            periodicidadeComboBox.TabIndex = 12;
            // 
            // valorLabel
            // 
            valorLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            valorLabel.AutoSize = true;
            valorLabel.ForeColor = Color.Yellow;
            valorLabel.Location = new Point(66, 162);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new Size(33, 15);
            valorLabel.TabIndex = 9;
            valorLabel.Text = "Valor";
            valorLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // valorTextBox
            // 
            valorTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            valorTextBox.ForeColor = Color.Black;
            valorTextBox.Location = new Point(105, 151);
            valorTextBox.Name = "valorTextBox";
            valorTextBox.PlaceholderText = "Digite o valor da meta";
            valorTextBox.Size = new Size(229, 23);
            valorTextBox.TabIndex = 10;
            valorTextBox.TextChanged += ValorTextBox_TextChanged;
            valorTextBox.Enter += ValorTextBox_Enter;
            valorTextBox.KeyPress += ValorTextBox_KeyPress;
            valorTextBox.Leave += ValorTextBox_Leave;
            // 
            // vendedorLabel
            // 
            vendedorLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            vendedorLabel.AutoSize = true;
            vendedorLabel.ForeColor = Color.Yellow;
            vendedorLabel.Location = new Point(42, 133);
            vendedorLabel.Name = "vendedorLabel";
            vendedorLabel.Size = new Size(57, 15);
            vendedorLabel.TabIndex = 7;
            vendedorLabel.Text = "Vendedor";
            vendedorLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // vendedorComboBox
            // 
            vendedorComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            vendedorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            vendedorComboBox.ForeColor = Color.Black;
            vendedorComboBox.FormattingEnabled = true;
            vendedorComboBox.Location = new Point(105, 122);
            vendedorComboBox.Name = "vendedorComboBox";
            vendedorComboBox.Size = new Size(229, 23);
            vendedorComboBox.TabIndex = 8;
            // 
            // categoriaLabel
            // 
            categoriaLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            categoriaLabel.AutoSize = true;
            categoriaLabel.ForeColor = Color.Yellow;
            categoriaLabel.Location = new Point(6, 104);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new Size(93, 15);
            categoriaLabel.TabIndex = 4;
            categoriaLabel.Text = "Tipo de Produto";
            categoriaLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // categoriaComboBox
            // 
            categoriaComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            categoriaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoriaComboBox.ForeColor = Color.Black;
            categoriaComboBox.FormattingEnabled = true;
            categoriaComboBox.Location = new Point(105, 93);
            categoriaComboBox.Name = "categoriaComboBox";
            categoriaComboBox.Size = new Size(229, 23);
            categoriaComboBox.TabIndex = 5;
            // 
            // formatoLabel
            // 
            formatoLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            formatoLabel.AutoSize = true;
            formatoLabel.ForeColor = Color.Yellow;
            formatoLabel.Location = new Point(47, 75);
            formatoLabel.Name = "formatoLabel";
            formatoLabel.RightToLeft = RightToLeft.No;
            formatoLabel.Size = new Size(52, 15);
            formatoLabel.TabIndex = 2;
            formatoLabel.Text = "Formato";
            formatoLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // formatoComboBox
            // 
            formatoComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            formatoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            formatoComboBox.ForeColor = Color.Black;
            formatoComboBox.FormattingEnabled = true;
            formatoComboBox.Location = new Point(105, 64);
            formatoComboBox.Name = "formatoComboBox";
            formatoComboBox.Size = new Size(229, 23);
            formatoComboBox.TabIndex = 3;
            formatoComboBox.SelectedIndexChanged += FormatoComboBox_SelectedIndexChanged;
            // 
            // nomeTextBox
            // 
            nomeTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nomeTextBox.ForeColor = Color.Black;
            nomeTextBox.Location = new Point(105, 35);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.PlaceholderText = "Digite o nome da meta";
            nomeTextBox.Size = new Size(229, 23);
            nomeTextBox.TabIndex = 1;
            nomeTextBox.TextChanged += NomeTextBox_TextChanged;
            // 
            // nomeLabel
            // 
            nomeLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nomeLabel.AutoSize = true;
            nomeLabel.ForeColor = Color.Yellow;
            nomeLabel.Location = new Point(62, 46);
            nomeLabel.Margin = new Padding(0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.RightToLeft = RightToLeft.No;
            nomeLabel.Size = new Size(40, 15);
            nomeLabel.TabIndex = 0;
            nomeLabel.Text = "Nome";
            nomeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmEditarMeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 46, 61);
            ClientSize = new Size(384, 316);
            Controls.Add(errorLabel);
            Controls.Add(botoesTableLayoutPanel);
            Controls.Add(cadastrarMetaGroupBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(400, 355);
            Name = "FrmEditarMeta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Meta";
            Load += FrmEditarMeta_Load;
            KeyDown += FrmEditarMeta_KeyDown;
            botoesTableLayoutPanel.ResumeLayout(false);
            cadastrarMetaGroupBox.ResumeLayout(false);
            cadastrarMetaGroupBox.PerformLayout();
            editarTableLayoutPanel.ResumeLayout(false);
            editarTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void SalvarButton_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ValorTextBox_Leave1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CancelarButton_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label errorLabel;
        private TableLayoutPanel botoesTableLayoutPanel;
        private Button cancelarButton;
        private Button salvarButton;
        private GroupBox cadastrarMetaGroupBox;
        private TableLayoutPanel editarTableLayoutPanel;
        private Label categoriaLabel;
        private ComboBox categoriaComboBox;
        private Label formatoLabel;
        private ComboBox formatoComboBox;
        private TextBox nomeTextBox;
        private Label vendedorLabel;
        private ComboBox vendedorComboBox;
        private Label valorLabel;
        private TextBox valorTextBox;
        private Label periodicidadeLabel;
        private ComboBox periodicidadeComboBox;
        private Label nomeLabel;
        private Button excluirButton;
        private Label idLabel;
        private Label idValueLabel;
    }
}