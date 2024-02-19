namespace InterfaceGui
{
    partial class frm_pdv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pdv));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            btnSelecionar = new Button();
            btnExcluir = new Button();
            panel_label = new Panel();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Cor = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btn_pesquisar = new Button();
            textBox_pesquisar = new TextBox();
            panel1 = new Panel();
            panel4 = new Panel();
            label_resultado = new Label();
            textBox_resultado = new TextBox();
            label_divisao = new Label();
            textBox_divisao = new TextBox();
            label_desconto = new Label();
            textBox_desconto = new TextBox();
            label_total = new Label();
            textBox_total = new TextBox();
            panel3 = new Panel();
            btn_pix = new Button();
            btn_dinheiro = new Button();
            btn_credito = new Button();
            btn_debito = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel_label.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(30, 44, 58);
            splitContainer1.Panel1.BackgroundImage = (Image)resources.GetObject("splitContainer1.Panel1.BackgroundImage");
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Center;
            splitContainer1.Panel1.ForeColor = SystemColors.ButtonHighlight;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Snow;
            splitContainer1.Panel2.Controls.Add(btnSelecionar);
            splitContainer1.Panel2.Controls.Add(btnExcluir);
            splitContainer1.Panel2.Controls.Add(panel_label);
            splitContainer1.Panel2.Controls.Add(dataGridView2);
            splitContainer1.Panel2.Controls.Add(btn_pesquisar);
            splitContainer1.Panel2.Controls.Add(textBox_pesquisar);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(1352, 729);
            splitContainer1.SplitterDistance = 337;
            splitContainer1.TabIndex = 0;
            // 
            // btnSelecionar
            // 
            btnSelecionar.BackColor = SystemColors.GradientActiveCaption;
            btnSelecionar.Location = new Point(365, 559);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(100, 23);
            btnSelecionar.TabIndex = 6;
            btnSelecionar.Text = "Selecionar tudo";
            btnSelecionar.UseVisualStyleBackColor = false;
            btnSelecionar.Visible = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = SystemColors.ScrollBar;
            btnExcluir.Location = new Point(234, 559);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(100, 23);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Visible = false;
            // 
            // panel_label
            // 
            panel_label.BackColor = Color.FromArgb(30, 44, 58);
            panel_label.Controls.Add(label1);
            panel_label.Location = new Point(5, 0);
            panel_label.Name = "panel_label";
            panel_label.Size = new Size(736, 70);
            panel_label.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(284, 13);
            label1.Name = "label1";
            label1.Size = new Size(194, 32);
            label1.TabIndex = 5;
            label1.Text = "Ponto de Venda";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.BackgroundColor = Color.Snow;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Codigo, Descricao, Preco, Marca, Cor, Quantidade, Total });
            dataGridView2.Location = new Point(5, 194);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(736, 359);
            dataGridView2.TabIndex = 3;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Descricao
            // 
            Descricao.HeaderText = "Descrição";
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            // 
            // Preco
            // 
            Preco.HeaderText = "Preço";
            Preco.Name = "Preco";
            Preco.ReadOnly = true;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            // 
            // Cor
            // 
            Cor.HeaderText = "Cor";
            Cor.Name = "Cor";
            Cor.ReadOnly = true;
            // 
            // Quantidade
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Quantidade.DefaultCellStyle = dataGridViewCellStyle1;
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // btn_pesquisar
            // 
            btn_pesquisar.Location = new Point(574, 89);
            btn_pesquisar.Name = "btn_pesquisar";
            btn_pesquisar.Size = new Size(167, 33);
            btn_pesquisar.TabIndex = 2;
            btn_pesquisar.Text = "Pesquisar";
            btn_pesquisar.UseVisualStyleBackColor = true;
            btn_pesquisar.Click += btn_pesquisar_Click;
            // 
            // textBox_pesquisar
            // 
            textBox_pesquisar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_pesquisar.Location = new Point(5, 89);
            textBox_pesquisar.Name = "textBox_pesquisar";
            textBox_pesquisar.PlaceholderText = "Produto";
            textBox_pesquisar.Size = new Size(540, 33);
            textBox_pesquisar.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 44, 58);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(747, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 726);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(label_resultado);
            panel4.Controls.Add(textBox_resultado);
            panel4.Controls.Add(label_divisao);
            panel4.Controls.Add(textBox_divisao);
            panel4.Controls.Add(label_desconto);
            panel4.Controls.Add(textBox_desconto);
            panel4.Controls.Add(label_total);
            panel4.Controls.Add(textBox_total);
            panel4.Location = new Point(19, 335);
            panel4.Name = "panel4";
            panel4.Size = new Size(233, 331);
            panel4.TabIndex = 1;
            // 
            // label_resultado
            // 
            label_resultado.BackColor = Color.Transparent;
            label_resultado.BorderStyle = BorderStyle.Fixed3D;
            label_resultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_resultado.ForeColor = SystemColors.Control;
            label_resultado.Location = new Point(0, 71);
            label_resultado.Name = "label_resultado";
            label_resultado.Size = new Size(117, 35);
            label_resultado.TabIndex = 7;
            label_resultado.Text = "Resultado";
            label_resultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_resultado
            // 
            textBox_resultado.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_resultado.Location = new Point(112, 71);
            textBox_resultado.Name = "textBox_resultado";
            textBox_resultado.ReadOnly = true;
            textBox_resultado.Size = new Size(118, 35);
            textBox_resultado.TabIndex = 6;
            textBox_resultado.Text = "0,00";
            textBox_resultado.TextAlign = HorizontalAlignment.Center;
            // 
            // label_divisao
            // 
            label_divisao.BackColor = Color.Transparent;
            label_divisao.BorderStyle = BorderStyle.Fixed3D;
            label_divisao.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_divisao.ForeColor = SystemColors.Control;
            label_divisao.Location = new Point(0, 16);
            label_divisao.Name = "label_divisao";
            label_divisao.Size = new Size(117, 35);
            label_divisao.TabIndex = 5;
            label_divisao.Text = "Dividir Valor";
            label_divisao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_divisao
            // 
            textBox_divisao.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_divisao.Location = new Point(112, 16);
            textBox_divisao.Name = "textBox_divisao";
            textBox_divisao.Size = new Size(118, 35);
            textBox_divisao.TabIndex = 4;
            textBox_divisao.Text = "1";
            textBox_divisao.TextAlign = HorizontalAlignment.Center;
            // 
            // label_desconto
            // 
            label_desconto.BackColor = Color.Transparent;
            label_desconto.BorderStyle = BorderStyle.Fixed3D;
            label_desconto.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_desconto.ForeColor = SystemColors.Control;
            label_desconto.Location = new Point(0, 124);
            label_desconto.Name = "label_desconto";
            label_desconto.Size = new Size(114, 35);
            label_desconto.TabIndex = 3;
            label_desconto.Text = "Desconto";
            label_desconto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_desconto
            // 
            textBox_desconto.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_desconto.Location = new Point(112, 124);
            textBox_desconto.Name = "textBox_desconto";
            textBox_desconto.Size = new Size(118, 35);
            textBox_desconto.TabIndex = 2;
            textBox_desconto.Text = "0,00";
            textBox_desconto.TextAlign = HorizontalAlignment.Center;
            // 
            // label_total
            // 
            label_total.BackColor = Color.Red;
            label_total.BorderStyle = BorderStyle.Fixed3D;
            label_total.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_total.ForeColor = SystemColors.Control;
            label_total.Location = new Point(0, 175);
            label_total.Name = "label_total";
            label_total.Size = new Size(117, 35);
            label_total.TabIndex = 1;
            label_total.Text = "Total";
            label_total.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_total
            // 
            textBox_total.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_total.Location = new Point(112, 175);
            textBox_total.Name = "textBox_total";
            textBox_total.ReadOnly = true;
            textBox_total.Size = new Size(118, 35);
            textBox_total.TabIndex = 0;
            textBox_total.Text = "0,00";
            textBox_total.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_pix);
            panel3.Controls.Add(btn_dinheiro);
            panel3.Controls.Add(btn_credito);
            panel3.Controls.Add(btn_debito);
            panel3.Location = new Point(19, 89);
            panel3.Name = "panel3";
            panel3.Size = new Size(233, 102);
            panel3.TabIndex = 0;
            // 
            // btn_pix
            // 
            btn_pix.BackColor = SystemColors.Control;
            btn_pix.Location = new Point(140, 64);
            btn_pix.Name = "btn_pix";
            btn_pix.Size = new Size(90, 35);
            btn_pix.TabIndex = 3;
            btn_pix.Text = "Pix";
            btn_pix.UseVisualStyleBackColor = false;
            // 
            // btn_dinheiro
            // 
            btn_dinheiro.BackColor = SystemColors.Control;
            btn_dinheiro.Location = new Point(0, 64);
            btn_dinheiro.Name = "btn_dinheiro";
            btn_dinheiro.Size = new Size(90, 35);
            btn_dinheiro.TabIndex = 2;
            btn_dinheiro.Text = "Dinheiro";
            btn_dinheiro.UseVisualStyleBackColor = false;
            // 
            // btn_credito
            // 
            btn_credito.BackColor = SystemColors.Control;
            btn_credito.Location = new Point(140, 3);
            btn_credito.Name = "btn_credito";
            btn_credito.Size = new Size(90, 35);
            btn_credito.TabIndex = 1;
            btn_credito.Text = "Crédito";
            btn_credito.UseVisualStyleBackColor = false;
            // 
            // btn_debito
            // 
            btn_debito.BackColor = SystemColors.Control;
            btn_debito.Location = new Point(3, 3);
            btn_debito.Name = "btn_debito";
            btn_debito.Size = new Size(90, 35);
            btn_debito.TabIndex = 0;
            btn_debito.Text = "Débito";
            btn_debito.UseVisualStyleBackColor = false;
            // 
            // frm_pdv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1352, 729);
            Controls.Add(splitContainer1);
            Name = "frm_pdv";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ponto de Venda";
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel_label.ResumeLayout(false);
            panel_label.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btn_pesquisar;
        private TextBox textBox_pesquisar;
        private Panel panel1;
        private Panel panel_label;
        private Label label1;
        private Panel panel3;
        private Button btn_pix;
        private Button btn_dinheiro;
        private Button btn_credito;
        private Button btn_debito;
        private Panel panel4;
        public DataGridView dataGridView2;
        private Label label_total;
        public TextBox textBox_total;
        private Label label_desconto;
        public TextBox textBox_desconto;
        public Button btnExcluir;
        public Button btnSelecionar;
        private Label label_divisao;
        public TextBox textBox_divisao;
        private Label label_resultado;
        public TextBox textBox_resultado;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Cor;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Total;
    }
}