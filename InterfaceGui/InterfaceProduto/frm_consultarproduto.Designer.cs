namespace InterfaceGui.InterfaceProduto
{
    partial class frm_consultarproduto
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

        #endregion

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Column_produto = new DataGridViewTextBoxColumn();
            Column_descricao = new DataGridViewTextBoxColumn();
            Column_preco = new DataGridViewTextBoxColumn();
            Column_categoria = new DataGridViewTextBoxColumn();
            Column_marca = new DataGridViewTextBoxColumn();
            Column_Cor = new DataGridViewTextBoxColumn();
            Column_estoque = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnPesquisar = new Button();
            label_produto = new Label();
            label_descricao = new Label();
            textBox_descricao = new TextBox();
            textBox_produto = new TextBox();
            btn_selecionar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 86);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(743, 232);
            dataGridView1.TabIndex = 0;
            // 
            // Column_produto
            // 
            Column_produto.Name = "Column_produto";
            // 
            // Column_descricao
            // 
            Column_descricao.Name = "Column_descricao";
            // 
            // Column_preco
            // 
            Column_preco.Name = "Column_preco";
            // 
            // Column_categoria
            // 
            Column_categoria.Name = "Column_categoria";
            // 
            // Column_marca
            // 
            Column_marca.Name = "Column_marca";
            // 
            // Column_Cor
            // 
            Column_Cor.Name = "Column_Cor";
            // 
            // Column_estoque
            // 
            Column_estoque.Name = "Column_estoque";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(197, 212, 230);
            panel1.Controls.Add(btnPesquisar);
            panel1.Controls.Add(label_produto);
            panel1.Controls.Add(label_descricao);
            panel1.Controls.Add(textBox_descricao);
            panel1.Controls.Add(textBox_produto);
            panel1.Location = new Point(28, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 62);
            panel1.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.SteelBlue;
            btnPesquisar.Location = new Point(659, 22);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(81, 23);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += BtnPesquisar_Click;
            // 
            // label_produto
            // 
            label_produto.AutoSize = true;
            label_produto.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_produto.Location = new Point(0, 3);
            label_produto.Name = "label_produto";
            label_produto.Size = new Size(91, 13);
            label_produto.TabIndex = 0;
            label_produto.Text = "Código Produto";
            // 
            // label_descricao
            // 
            label_descricao.AutoSize = true;
            label_descricao.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_descricao.Location = new Point(161, 3);
            label_descricao.Name = "label_descricao";
            label_descricao.Size = new Size(56, 13);
            label_descricao.TabIndex = 1;
            label_descricao.Text = "Descrição";
            // 
            // textBox_descricao
            // 
            textBox_descricao.Location = new Point(161, 23);
            textBox_descricao.Name = "textBox_descricao";
            textBox_descricao.PlaceholderText = "Descrição";
            textBox_descricao.Size = new Size(492, 23);
            textBox_descricao.TabIndex = 1;
            // 
            // textBox_produto
            // 
            textBox_produto.Location = new Point(0, 23);
            textBox_produto.Name = "textBox_produto";
            textBox_produto.Size = new Size(138, 23);
            textBox_produto.TabIndex = 0;
            textBox_produto.Text = "0";
            // 
            // btn_selecionar
            // 
            btn_selecionar.BackColor = SystemColors.Control;
            btn_selecionar.Location = new Point(317, 324);
            btn_selecionar.Name = "btn_selecionar";
            btn_selecionar.Size = new Size(158, 23);
            btn_selecionar.TabIndex = 3;
            btn_selecionar.Text = "Selecionar";
            btn_selecionar.UseVisualStyleBackColor = false;
            btn_selecionar.Visible = false;
            btn_selecionar.Click += BtnPesquisar_Click;
            // 
            // frm_consultarproduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 212, 230);
            ClientSize = new Size(800, 351);
            Controls.Add(btn_selecionar);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "frm_consultarproduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Produto";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private async void BtnPesquisar_Click(object sender, EventArgs e)
        {
            int codigoProduto;
            if (textBox_produto.Text == "" || textBox_produto.Text == null)
            {
                codigoProduto = 0;
            }

            else
            {
                codigoProduto = Convert.ToInt32(textBox_produto.Text);
            }


            string descricao = textBox_descricao.Text;


            var filtro = await _produtoService.GetAsyncProduto(codigoProduto, descricao);

            dataGridView1.DataSource = filtro;
        }
        private DataGridViewTextBoxColumn Column_produto;
        private DataGridViewTextBoxColumn Column_descricao;
        private DataGridViewTextBoxColumn Column_preco;
        private DataGridViewTextBoxColumn Column_categoria;
        private DataGridViewTextBoxColumn Column_marca;
        private DataGridViewTextBoxColumn Column_Cor;
        private DataGridViewTextBoxColumn Column_estoque;
        private Panel panel1;
        private Label label_produto;
        private Label label_descricao;
        private Button btnPesquisar;
        private TextBox textBox_descricao;
        private TextBox textBox_produto;
        private Button btnSelecionar;
        public Button btn_selecionar;
        public DataGridView dataGridView1;
    }

}
