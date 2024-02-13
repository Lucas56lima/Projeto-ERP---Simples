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
            splitContainer1 = new SplitContainer();
            panel_label = new Panel();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Cor = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            btn_pesquisar = new Button();
            textBox_pesquisar = new TextBox();
            panel1 = new Panel();
            panel4 = new Panel();
            label_desconto = new Label();
            textBox1 = new TextBox();
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
            splitContainer1.Panel2.Controls.Add(panel_label);
            splitContainer1.Panel2.Controls.Add(dataGridView2);
            splitContainer1.Panel2.Controls.Add(btn_pesquisar);
            splitContainer1.Panel2.Controls.Add(textBox_pesquisar);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(1352, 729);
            splitContainer1.SplitterDistance = 337;
            splitContainer1.TabIndex = 0;
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
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.BackgroundColor = Color.Snow;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Codigo, Descricao, Preco, Marca, Cor, Quantidade });
            dataGridView2.Location = new Point(8, 194);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(733, 387);
            dataGridView2.TabIndex = 3;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            // 
            // Descricao
            // 
            Descricao.HeaderText = "Descrição";
            Descricao.Name = "Descricao";
            // 
            // Preco
            // 
            Preco.HeaderText = "Preço";
            Preco.Name = "Preco";
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.Name = "Marca";
            // 
            // Cor
            // 
            Cor.HeaderText = "Cor";
            Cor.Name = "Cor";
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
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
            panel4.Controls.Add(label_desconto);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label_total);
            panel4.Controls.Add(textBox_total);
            panel4.Location = new Point(32, 335);
            panel4.Name = "panel4";
            panel4.Size = new Size(199, 331);
            panel4.TabIndex = 1;
            // 
            // label_desconto
            // 
            label_desconto.BackColor = Color.Tomato;
            label_desconto.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_desconto.ForeColor = SystemColors.Control;
            label_desconto.Location = new Point(12, 33);
            label_desconto.Name = "label_desconto";
            label_desconto.Size = new Size(105, 35);
            label_desconto.TabIndex = 3;
            label_desconto.Text = "Desconto";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(112, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(85, 35);
            textBox1.TabIndex = 2;
            textBox1.Text = "0,00";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label_total
            // 
            label_total.BackColor = Color.Red;
            label_total.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_total.ForeColor = SystemColors.Control;
            label_total.Location = new Point(12, 83);
            label_total.Name = "label_total";
            label_total.Size = new Size(83, 43);
            label_total.TabIndex = 1;
            label_total.Text = "Total";
            // 
            // textBox_total
            // 
            textBox_total.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_total.Location = new Point(95, 83);
            textBox_total.Name = "textBox_total";
            textBox_total.Size = new Size(102, 43);
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
            panel3.Location = new Point(32, 89);
            panel3.Name = "panel3";
            panel3.Size = new Size(199, 107);
            panel3.TabIndex = 0;
            // 
            // btn_pix
            // 
            btn_pix.BackColor = SystemColors.Control;
            btn_pix.Location = new Point(112, 67);
            btn_pix.Name = "btn_pix";
            btn_pix.Size = new Size(75, 35);
            btn_pix.TabIndex = 3;
            btn_pix.Text = "Pix";
            btn_pix.UseVisualStyleBackColor = false;
            // 
            // btn_dinheiro
            // 
            btn_dinheiro.BackColor = SystemColors.Control;
            btn_dinheiro.Location = new Point(12, 67);
            btn_dinheiro.Name = "btn_dinheiro";
            btn_dinheiro.Size = new Size(75, 35);
            btn_dinheiro.TabIndex = 2;
            btn_dinheiro.Text = "Dinheiro";
            btn_dinheiro.UseVisualStyleBackColor = false;
            // 
            // btn_credito
            // 
            btn_credito.BackColor = SystemColors.Control;
            btn_credito.Location = new Point(112, 11);
            btn_credito.Name = "btn_credito";
            btn_credito.Size = new Size(75, 35);
            btn_credito.TabIndex = 1;
            btn_credito.Text = "Crédito";
            btn_credito.UseVisualStyleBackColor = false;
            // 
            // btn_debito
            // 
            btn_debito.BackColor = SystemColors.Control;
            btn_debito.Location = new Point(12, 11);
            btn_debito.Name = "btn_debito";
            btn_debito.Size = new Size(75, 35);
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
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Cor;
        private DataGridViewTextBoxColumn Quantidade;
        public DataGridView dataGridView2;
        private Label label_total;
        public TextBox textBox_total;
        private Label label_desconto;
        public TextBox textBox1;
    }
}