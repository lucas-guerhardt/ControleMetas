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
            label1 = new Label();
            comboBox1 = new ComboBox();
            nomeLabel = new Label();
            adicionarButton = new Button();
            cancelarButton = new Button();
            botoesTableLayoutPanel = new TableLayoutPanel();
            cadastrarMetaGroupBox.SuspendLayout();
            cadastroTableLayoutPanel.SuspendLayout();
            botoesTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // cadastrarMetaGroupBox
            // 
            cadastrarMetaGroupBox.Controls.Add(cadastroTableLayoutPanel);
            cadastrarMetaGroupBox.Font = new Font("Segoe UI", 9F);
            cadastrarMetaGroupBox.ForeColor = Color.White;
            cadastrarMetaGroupBox.Location = new Point(20, 14);
            cadastrarMetaGroupBox.MinimumSize = new Size(328, 496);
            cadastrarMetaGroupBox.Name = "cadastrarMetaGroupBox";
            cadastrarMetaGroupBox.Size = new Size(356, 496);
            cadastrarMetaGroupBox.TabIndex = 1;
            cadastrarMetaGroupBox.TabStop = false;
            cadastrarMetaGroupBox.Text = "Cadastrar Nova Meta";
            cadastrarMetaGroupBox.Enter += groupBox1_Enter;
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
            cadastroTableLayoutPanel.Controls.Add(label1, 0, 5);
            cadastroTableLayoutPanel.Controls.Add(comboBox1, 1, 5);
            cadastroTableLayoutPanel.Controls.Add(nomeLabel, 0, 0);
            cadastroTableLayoutPanel.Dock = DockStyle.Fill;
            cadastroTableLayoutPanel.Location = new Point(3, 19);
            cadastroTableLayoutPanel.Name = "cadastroTableLayoutPanel";
            cadastroTableLayoutPanel.Padding = new Padding(3);
            cadastroTableLayoutPanel.RowCount = 6;
            cadastroTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            cadastroTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            cadastroTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            cadastroTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            cadastroTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            cadastroTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            cadastroTableLayoutPanel.Size = new Size(350, 474);
            cadastroTableLayoutPanel.TabIndex = 2;
            cadastroTableLayoutPanel.Paint += cadastroTableLayoutPanel_Paint;
            // 
            // categoriaLabel
            // 
            categoriaLabel.Anchor = AnchorStyles.Right;
            categoriaLabel.AutoSize = true;
            categoriaLabel.ForeColor = Color.Yellow;
            categoriaLabel.Location = new Point(27, 189);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new Size(58, 15);
            categoriaLabel.TabIndex = 4;
            categoriaLabel.Text = "Categoria";
            categoriaLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // categoriaComboBox
            // 
            categoriaComboBox.Anchor = AnchorStyles.Left;
            categoriaComboBox.ForeColor = Color.Black;
            categoriaComboBox.FormattingEnabled = true;
            categoriaComboBox.Location = new Point(91, 185);
            categoriaComboBox.Name = "categoriaComboBox";
            categoriaComboBox.Size = new Size(229, 23);
            categoriaComboBox.TabIndex = 5;
            // 
            // formatoLabel
            // 
            formatoLabel.Anchor = AnchorStyles.Right;
            formatoLabel.AutoSize = true;
            formatoLabel.ForeColor = Color.Yellow;
            formatoLabel.Location = new Point(33, 112);
            formatoLabel.Name = "formatoLabel";
            formatoLabel.RightToLeft = RightToLeft.No;
            formatoLabel.Size = new Size(52, 15);
            formatoLabel.TabIndex = 2;
            formatoLabel.Text = "Formato";
            formatoLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // formatoComboBox
            // 
            formatoComboBox.Anchor = AnchorStyles.Left;
            formatoComboBox.ForeColor = Color.Black;
            formatoComboBox.FormattingEnabled = true;
            formatoComboBox.Location = new Point(91, 108);
            formatoComboBox.Name = "formatoComboBox";
            formatoComboBox.Size = new Size(229, 23);
            formatoComboBox.TabIndex = 3;
            // 
            // nomeMetaTextBox
            // 
            nomeMetaTextBox.Anchor = AnchorStyles.Left;
            nomeMetaTextBox.ForeColor = Color.Black;
            nomeMetaTextBox.Location = new Point(91, 30);
            nomeMetaTextBox.Name = "nomeMetaTextBox";
            nomeMetaTextBox.PlaceholderText = "Digite o nome da meta";
            nomeMetaTextBox.Size = new Size(229, 23);
            nomeMetaTextBox.TabIndex = 1;
            // 
            // vendedorLabel
            // 
            vendedorLabel.Anchor = AnchorStyles.Right;
            vendedorLabel.AutoSize = true;
            vendedorLabel.ForeColor = Color.Yellow;
            vendedorLabel.Location = new Point(28, 266);
            vendedorLabel.Name = "vendedorLabel";
            vendedorLabel.Size = new Size(57, 15);
            vendedorLabel.TabIndex = 7;
            vendedorLabel.Text = "Vendedor";
            vendedorLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // vendedorComboBox
            // 
            vendedorComboBox.Anchor = AnchorStyles.Left;
            vendedorComboBox.ForeColor = Color.Black;
            vendedorComboBox.FormattingEnabled = true;
            vendedorComboBox.Location = new Point(91, 262);
            vendedorComboBox.Name = "vendedorComboBox";
            vendedorComboBox.Size = new Size(229, 23);
            vendedorComboBox.TabIndex = 8;
            // 
            // valorLabel
            // 
            valorLabel.Anchor = AnchorStyles.Right;
            valorLabel.AutoSize = true;
            valorLabel.ForeColor = Color.Yellow;
            valorLabel.Location = new Point(52, 343);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new Size(33, 15);
            valorLabel.TabIndex = 9;
            valorLabel.Text = "Valor";
            valorLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // valorTextBox
            // 
            valorTextBox.Anchor = AnchorStyles.Left;
            valorTextBox.ForeColor = Color.Black;
            valorTextBox.Location = new Point(91, 339);
            valorTextBox.Name = "valorTextBox";
            valorTextBox.PlaceholderText = "Digite o valor da meta";
            valorTextBox.Size = new Size(229, 23);
            valorTextBox.TabIndex = 10;
            valorTextBox.TextChanged += valorTextBox_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(6, 422);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 11;
            label1.Text = "Periodicidade";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left;
            comboBox1.ForeColor = Color.Black;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(91, 418);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 23);
            comboBox1.TabIndex = 12;
            // 
            // nomeLabel
            // 
            nomeLabel.Anchor = AnchorStyles.Right;
            nomeLabel.AutoSize = true;
            nomeLabel.ForeColor = Color.Yellow;
            nomeLabel.Location = new Point(48, 34);
            nomeLabel.Margin = new Padding(0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.RightToLeft = RightToLeft.No;
            nomeLabel.Size = new Size(40, 15);
            nomeLabel.TabIndex = 0;
            nomeLabel.Text = "Nome";
            nomeLabel.TextAlign = ContentAlignment.MiddleRight;
            nomeLabel.Click += nomeLabel_Click;
            // 
            // adicionarButton
            // 
            adicionarButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            adicionarButton.BackColor = Color.Lime;
            adicionarButton.Cursor = Cursors.Hand;
            adicionarButton.FlatAppearance.BorderColor = Color.LimeGreen;
            adicionarButton.FlatAppearance.MouseDownBackColor = Color.Green;
            adicionarButton.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            adicionarButton.FlatStyle = FlatStyle.Flat;
            adicionarButton.Font = new Font("Segoe UI", 12F);
            adicionarButton.ForeColor = Color.Black;
            adicionarButton.Location = new Point(181, 3);
            adicionarButton.Name = "adicionarButton";
            adicionarButton.Size = new Size(92, 32);
            adicionarButton.TabIndex = 0;
            adicionarButton.Text = "Adicionar";
            adicionarButton.UseVisualStyleBackColor = false;
            adicionarButton.Click += adicionarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cancelarButton.BackColor = SystemColors.ButtonHighlight;
            cancelarButton.Cursor = Cursors.Hand;
            cancelarButton.FlatAppearance.BorderColor = Color.Silver;
            cancelarButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            cancelarButton.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            cancelarButton.FlatStyle = FlatStyle.Flat;
            cancelarButton.Font = new Font("Segoe UI", 12F);
            cancelarButton.ForeColor = Color.Black;
            cancelarButton.Location = new Point(279, 3);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(92, 32);
            cancelarButton.TabIndex = 1;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = false;
            // 
            // botoesTableLayoutPanel
            // 
            botoesTableLayoutPanel.ColumnCount = 2;
            botoesTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            botoesTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            botoesTableLayoutPanel.Controls.Add(cancelarButton, 1, 0);
            botoesTableLayoutPanel.Controls.Add(adicionarButton, 0, 0);
            botoesTableLayoutPanel.Dock = DockStyle.Bottom;
            botoesTableLayoutPanel.Location = new Point(5, 545);
            botoesTableLayoutPanel.Name = "botoesTableLayoutPanel";
            botoesTableLayoutPanel.RowCount = 1;
            botoesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            botoesTableLayoutPanel.Size = new Size(374, 61);
            botoesTableLayoutPanel.TabIndex = 2;
            botoesTableLayoutPanel.Paint += botoesTableLayoutPanel_Paint;
            // 
            // FrmCadastroMeta
            // 
            AcceptButton = adicionarButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(33, 46, 61);
            CancelButton = cancelarButton;
            ClientSize = new Size(384, 611);
            Controls.Add(botoesTableLayoutPanel);
            Controls.Add(cadastrarMetaGroupBox);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(400, 650);
            Name = "FrmCadastroMeta";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Nova Meta";
            Load += FrmCadastroMeta_Load;
            cadastrarMetaGroupBox.ResumeLayout(false);
            cadastrarMetaGroupBox.PerformLayout();
            cadastroTableLayoutPanel.ResumeLayout(false);
            cadastroTableLayoutPanel.PerformLayout();
            botoesTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
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
        private Label label1;
        private ComboBox comboBox1;
        private Button adicionarButton;
        private Button cancelarButton;
        private TableLayoutPanel botoesTableLayoutPanel;
    }
}