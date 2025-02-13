namespace ControleMetas.Forms
{
    partial class FrmCadastroMeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroMeta));
            cadastrarMetaGroupBox = new GroupBox();
            cadastroTableLayoutPanel = new TableLayoutPanel();
            categoriaLabel = new Label();
            categoriaComboBox = new ComboBox();
            formatoLabel = new Label();
            formatoComboBox = new ComboBox();
            nomeMetaTextBox = new TextBox();
            vendedorLabel = new Label();
            vendedorComboBox = new ComboBox();
            valorLabel = new Label();
            valorTextBox = new TextBox();
            periodicidadeLabel = new Label();
            periodicidadeComboBox = new ComboBox();
            nomeLabel = new Label();
            adicionarButton = new Button();
            cancelarButton = new Button();
            botoesTableLayoutPanel = new TableLayoutPanel();
            errorLabel = new Label();
            cadastrarMetaGroupBox.SuspendLayout();
            cadastroTableLayoutPanel.SuspendLayout();
            botoesTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // cadastrarMetaGroupBox
            // 
            cadastrarMetaGroupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cadastrarMetaGroupBox.Controls.Add(cadastroTableLayoutPanel);
            cadastrarMetaGroupBox.Font = new Font("Montserrat", 8.999999F);
            cadastrarMetaGroupBox.ForeColor = Color.White;
            cadastrarMetaGroupBox.Location = new Point(23, 17);
            cadastrarMetaGroupBox.Margin = new Padding(3, 4, 3, 4);
            cadastrarMetaGroupBox.Name = "cadastrarMetaGroupBox";
            cadastrarMetaGroupBox.Padding = new Padding(3, 4, 3, 4);
            cadastrarMetaGroupBox.Size = new Size(406, 250);
            cadastrarMetaGroupBox.TabIndex = 1;
            cadastrarMetaGroupBox.TabStop = false;
            cadastrarMetaGroupBox.Text = "[+] Adicionar Nova Meta";
            // 
            // cadastroTableLayoutPanel
            // 
            cadastroTableLayoutPanel.AutoSize = true;
            cadastroTableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cadastroTableLayoutPanel.ColumnCount = 2;
            cadastroTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            cadastroTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            cadastroTableLayoutPanel.Controls.Add(categoriaLabel, 0, 2);
            cadastroTableLayoutPanel.Controls.Add(categoriaComboBox, 1, 2);
            cadastroTableLayoutPanel.Controls.Add(formatoLabel, 0, 1);
            cadastroTableLayoutPanel.Controls.Add(formatoComboBox, 1, 1);
            cadastroTableLayoutPanel.Controls.Add(nomeMetaTextBox, 1, 0);
            cadastroTableLayoutPanel.Controls.Add(vendedorLabel, 0, 3);
            cadastroTableLayoutPanel.Controls.Add(vendedorComboBox, 1, 3);
            cadastroTableLayoutPanel.Controls.Add(valorLabel, 0, 4);
            cadastroTableLayoutPanel.Controls.Add(valorTextBox, 1, 4);
            cadastroTableLayoutPanel.Controls.Add(periodicidadeLabel, 0, 5);
            cadastroTableLayoutPanel.Controls.Add(periodicidadeComboBox, 1, 5);
            cadastroTableLayoutPanel.Controls.Add(nomeLabel, 0, 0);
            cadastroTableLayoutPanel.Location = new Point(3, 23);
            cadastroTableLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            cadastroTableLayoutPanel.Name = "cadastroTableLayoutPanel";
            cadastroTableLayoutPanel.Padding = new Padding(3, 4, 3, 4);
            cadastroTableLayoutPanel.RowCount = 6;
            cadastroTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            cadastroTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            cadastroTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            cadastroTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            cadastroTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            cadastroTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            cadastroTableLayoutPanel.Size = new Size(385, 218);
            cadastroTableLayoutPanel.TabIndex = 2;
            cadastroTableLayoutPanel.Paint += CadastroTableLayoutPanel_Paint;
            // 
            // categoriaLabel
            // 
            categoriaLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            categoriaLabel.AutoSize = true;
            categoriaLabel.ForeColor = Color.Yellow;
            categoriaLabel.Location = new Point(6, 91);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new Size(106, 18);
            categoriaLabel.TabIndex = 4;
            categoriaLabel.Text = "Tipo de Produto";
            categoriaLabel.TextAlign = ContentAlignment.MiddleRight;
            categoriaLabel.Click += CategoriaLabel_Click;
            // 
            // categoriaComboBox
            // 
            categoriaComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            categoriaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoriaComboBox.FlatStyle = FlatStyle.Flat;
            categoriaComboBox.ForeColor = Color.Black;
            categoriaComboBox.FormattingEnabled = true;
            categoriaComboBox.Location = new Point(118, 82);
            categoriaComboBox.Margin = new Padding(3, 4, 3, 4);
            categoriaComboBox.Name = "categoriaComboBox";
            categoriaComboBox.Size = new Size(261, 26);
            categoriaComboBox.TabIndex = 5;
            // 
            // formatoLabel
            // 
            formatoLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            formatoLabel.AutoSize = true;
            formatoLabel.ForeColor = Color.Yellow;
            formatoLabel.Location = new Point(50, 56);
            formatoLabel.Name = "formatoLabel";
            formatoLabel.RightToLeft = RightToLeft.No;
            formatoLabel.Size = new Size(62, 18);
            formatoLabel.TabIndex = 2;
            formatoLabel.Text = "Formato";
            formatoLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // formatoComboBox
            // 
            formatoComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            formatoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            formatoComboBox.FlatStyle = FlatStyle.Flat;
            formatoComboBox.ForeColor = Color.Black;
            formatoComboBox.FormattingEnabled = true;
            formatoComboBox.Location = new Point(118, 47);
            formatoComboBox.Margin = new Padding(3, 4, 3, 4);
            formatoComboBox.Name = "formatoComboBox";
            formatoComboBox.Size = new Size(261, 26);
            formatoComboBox.TabIndex = 3;
            formatoComboBox.SelectedIndexChanged += FormatoComboBox_SelectedIndexChanged;
            // 
            // nomeMetaTextBox
            // 
            nomeMetaTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nomeMetaTextBox.ForeColor = Color.Black;
            nomeMetaTextBox.Location = new Point(118, 13);
            nomeMetaTextBox.Margin = new Padding(3, 4, 3, 4);
            nomeMetaTextBox.Name = "nomeMetaTextBox";
            nomeMetaTextBox.PlaceholderText = "Digite o nome da meta";
            nomeMetaTextBox.Size = new Size(261, 22);
            nomeMetaTextBox.TabIndex = 1;
            nomeMetaTextBox.TextChanged += NomeMetaTextBox_TextChanged;
            // 
            // vendedorLabel
            // 
            vendedorLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            vendedorLabel.AutoSize = true;
            vendedorLabel.ForeColor = Color.Yellow;
            vendedorLabel.Location = new Point(46, 126);
            vendedorLabel.Name = "vendedorLabel";
            vendedorLabel.Size = new Size(66, 18);
            vendedorLabel.TabIndex = 7;
            vendedorLabel.Text = "Vendedor";
            vendedorLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // vendedorComboBox
            // 
            vendedorComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            vendedorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            vendedorComboBox.FlatStyle = FlatStyle.Flat;
            vendedorComboBox.ForeColor = Color.Black;
            vendedorComboBox.FormattingEnabled = true;
            vendedorComboBox.Location = new Point(118, 117);
            vendedorComboBox.Margin = new Padding(3, 4, 3, 4);
            vendedorComboBox.Name = "vendedorComboBox";
            vendedorComboBox.Size = new Size(261, 26);
            vendedorComboBox.TabIndex = 8;
            // 
            // valorLabel
            // 
            valorLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            valorLabel.AutoSize = true;
            valorLabel.ForeColor = Color.Yellow;
            valorLabel.Location = new Point(74, 161);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new Size(38, 18);
            valorLabel.TabIndex = 9;
            valorLabel.Text = "Valor";
            valorLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // valorTextBox
            // 
            valorTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            valorTextBox.ForeColor = Color.Black;
            valorTextBox.Location = new Point(118, 153);
            valorTextBox.Margin = new Padding(3, 4, 3, 4);
            valorTextBox.Name = "valorTextBox";
            valorTextBox.PlaceholderText = "Digite o valor da meta";
            valorTextBox.Size = new Size(261, 22);
            valorTextBox.TabIndex = 10;
            valorTextBox.TextChanged += ValorTextBox_TextChanged;
            valorTextBox.Enter += ValorTextBox_Enter;
            valorTextBox.KeyPress += ValorTextBox_KeyPress;
            valorTextBox.Leave += ValorTextBox_Leave;
            // 
            // periodicidadeLabel
            // 
            periodicidadeLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            periodicidadeLabel.AutoSize = true;
            periodicidadeLabel.ForeColor = Color.Yellow;
            periodicidadeLabel.Location = new Point(21, 196);
            periodicidadeLabel.Name = "periodicidadeLabel";
            periodicidadeLabel.Size = new Size(91, 18);
            periodicidadeLabel.TabIndex = 11;
            periodicidadeLabel.Text = "Periodicidade";
            periodicidadeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // periodicidadeComboBox
            // 
            periodicidadeComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            periodicidadeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            periodicidadeComboBox.FlatStyle = FlatStyle.Flat;
            periodicidadeComboBox.ForeColor = Color.Black;
            periodicidadeComboBox.FormattingEnabled = true;
            periodicidadeComboBox.Location = new Point(118, 187);
            periodicidadeComboBox.Margin = new Padding(3, 4, 3, 4);
            periodicidadeComboBox.Name = "periodicidadeComboBox";
            periodicidadeComboBox.Size = new Size(261, 26);
            periodicidadeComboBox.TabIndex = 12;
            periodicidadeComboBox.SelectedIndexChanged += PeriodicidadeComboBox_SelectedIndexChanged;
            // 
            // nomeLabel
            // 
            nomeLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nomeLabel.AutoSize = true;
            nomeLabel.ForeColor = Color.Yellow;
            nomeLabel.Location = new Point(69, 21);
            nomeLabel.Margin = new Padding(0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.RightToLeft = RightToLeft.No;
            nomeLabel.Size = new Size(46, 18);
            nomeLabel.TabIndex = 0;
            nomeLabel.Text = "Nome";
            nomeLabel.TextAlign = ContentAlignment.MiddleRight;
            nomeLabel.Click += NomeLabel_Click;
            // 
            // adicionarButton
            // 
            adicionarButton.Anchor = AnchorStyles.Right;
            adicionarButton.BackColor = Color.Green;
            adicionarButton.Cursor = Cursors.Hand;
            adicionarButton.FlatAppearance.BorderColor = Color.White;
            adicionarButton.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            adicionarButton.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            adicionarButton.FlatStyle = FlatStyle.Flat;
            adicionarButton.Font = new Font("Montserrat", 8.999999F);
            adicionarButton.ForeColor = Color.White;
            adicionarButton.Location = new Point(156, 14);
            adicionarButton.Margin = new Padding(3, 4, 3, 4);
            adicionarButton.MinimumSize = new Size(131, 38);
            adicionarButton.Name = "adicionarButton";
            adicionarButton.Size = new Size(131, 38);
            adicionarButton.TabIndex = 0;
            adicionarButton.Text = "Adicionar [+]";
            adicionarButton.UseVisualStyleBackColor = false;
            adicionarButton.Click += AdicionarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Anchor = AnchorStyles.Left;
            cancelarButton.BackColor = Color.Transparent;
            cancelarButton.CausesValidation = false;
            cancelarButton.Cursor = Cursors.Hand;
            cancelarButton.FlatAppearance.BorderColor = Color.White;
            cancelarButton.FlatAppearance.MouseDownBackColor = Color.LightGray;
            cancelarButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            cancelarButton.FlatStyle = FlatStyle.Flat;
            cancelarButton.Font = new Font("Montserrat", 8.999999F);
            cancelarButton.ForeColor = Color.White;
            cancelarButton.Location = new Point(293, 14);
            cancelarButton.Margin = new Padding(3, 4, 3, 4);
            cancelarButton.MinimumSize = new Size(131, 38);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(131, 38);
            cancelarButton.TabIndex = 1;
            cancelarButton.Text = "< Voltar (Esc)";
            cancelarButton.UseVisualStyleBackColor = false;
            cancelarButton.Click += CancelarButton_Click;
            // 
            // botoesTableLayoutPanel
            // 
            botoesTableLayoutPanel.ColumnCount = 2;
            botoesTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            botoesTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            botoesTableLayoutPanel.Controls.Add(cancelarButton, 1, 0);
            botoesTableLayoutPanel.Controls.Add(adicionarButton, 0, 0);
            botoesTableLayoutPanel.Dock = DockStyle.Bottom;
            botoesTableLayoutPanel.Font = new Font("Montserrat", 8.999999F);
            botoesTableLayoutPanel.Location = new Point(6, 306);
            botoesTableLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            botoesTableLayoutPanel.Name = "botoesTableLayoutPanel";
            botoesTableLayoutPanel.RowCount = 1;
            botoesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            botoesTableLayoutPanel.Size = new Size(427, 67);
            botoesTableLayoutPanel.TabIndex = 2;
            botoesTableLayoutPanel.Paint += BotoesTableLayoutPanel_Paint;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Montserrat", 8.999999F);
            errorLabel.Location = new Point(23, 284);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 18);
            errorLabel.TabIndex = 3;
            // 
            // FrmCadastroMeta
            // 
            AcceptButton = adicionarButton;
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(33, 46, 61);
            CancelButton = cancelarButton;
            ClientSize = new Size(439, 379);
            Controls.Add(errorLabel);
            Controls.Add(botoesTableLayoutPanel);
            Controls.Add(cadastrarMetaGroupBox);
            Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(455, 418);
            Name = "FrmCadastroMeta";
            Padding = new Padding(6);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "[+] Adicionar Nova Meta";
            Load += FrmCadastroMeta_Load;
            cadastrarMetaGroupBox.ResumeLayout(false);
            cadastrarMetaGroupBox.PerformLayout();
            cadastroTableLayoutPanel.ResumeLayout(false);
            cadastroTableLayoutPanel.PerformLayout();
            botoesTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox cadastrarMetaGroupBox;
        private TableLayoutPanel cadastroTableLayoutPanel;
        private Label categoriaLabel;
        private ComboBox categoriaComboBox;
        private Label formatoLabel;
        private ComboBox formatoComboBox;
        private Label nomeLabel;
        private TextBox nomeMetaTextBox;
        private Label vendedorLabel;
        private ComboBox vendedorComboBox;
        private Label valorLabel;
        private TextBox valorTextBox;
        private Label periodicidadeLabel;
        private ComboBox periodicidadeComboBox;
        private Button adicionarButton;
        private Button cancelarButton;
        private TableLayoutPanel botoesTableLayoutPanel;
        private Label errorLabel;
    }
}