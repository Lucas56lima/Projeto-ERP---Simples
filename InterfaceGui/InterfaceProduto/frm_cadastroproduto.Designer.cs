using Domain.Commands;

namespace InterfaceGui.InterfaceProduto
{
    partial class frm_cadastroproduto
        
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_cabecalho = new Panel();
            label_cabecalho = new Label();
            panel_cadastro = new Panel();
            label1 = new Label();
            btnSalvar = new Button();
            textBox_codigo = new TextBox();
            label5 = new Label();
            listBox_marca = new ListBox();
            textBox_preco = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            listBox_subcategoria = new ListBox();
            label2 = new Label();
            listBox_cor = new ListBox();
            label_categoria = new Label();
            listBox_categoria = new ListBox();
            textBox_descricao = new TextBox();
            label_descricao = new Label();
            panel_cabecalho.SuspendLayout();
            panel_cadastro.SuspendLayout();
            SuspendLayout();
            // 
            // panel_cabecalho
            // 
            panel_cabecalho.BackColor = SystemColors.ButtonHighlight;
            panel_cabecalho.BorderStyle = BorderStyle.Fixed3D;
            panel_cabecalho.Controls.Add(label_cabecalho);
            panel_cabecalho.Location = new Point(11, 4);
            panel_cabecalho.Name = "panel_cabecalho";
            panel_cabecalho.Size = new Size(582, 41);
            panel_cabecalho.TabIndex = 0;
            // 
            // label_cabecalho
            // 
            label_cabecalho.AutoSize = true;
            label_cabecalho.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_cabecalho.Location = new Point(189, 12);
            label_cabecalho.Name = "label_cabecalho";
            label_cabecalho.Size = new Size(188, 25);
            label_cabecalho.TabIndex = 0;
            label_cabecalho.Text = "Cadastro de Produto";
            label_cabecalho.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel_cadastro
            // 
            panel_cadastro.BackColor = SystemColors.ButtonHighlight;
            panel_cadastro.BorderStyle = BorderStyle.Fixed3D;
            panel_cadastro.Controls.Add(label1);
            panel_cadastro.Controls.Add(btnSalvar);
            panel_cadastro.Controls.Add(textBox_codigo);
            panel_cadastro.Controls.Add(label5);
            panel_cadastro.Controls.Add(listBox_marca);
            panel_cadastro.Controls.Add(textBox_preco);
            panel_cadastro.Controls.Add(label6);
            panel_cadastro.Controls.Add(label4);
            panel_cadastro.Controls.Add(label3);
            panel_cadastro.Controls.Add(listBox_subcategoria);
            panel_cadastro.Controls.Add(label2);
            panel_cadastro.Controls.Add(listBox_cor);
            panel_cadastro.Controls.Add(label_categoria);
            panel_cadastro.Controls.Add(listBox_categoria);
            panel_cadastro.Controls.Add(textBox_descricao);
            panel_cadastro.Controls.Add(label_descricao);
            panel_cadastro.Location = new Point(12, 58);
            panel_cadastro.Name = "panel_cadastro";
            panel_cadastro.Size = new Size(581, 250);
            panel_cadastro.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(30, 40);
            label1.Name = "label1";
            label1.Size = new Size(58, 24);
            label1.TabIndex = 29;
            label1.Text = "Descrição";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.ActiveBorder;
            btnSalvar.Location = new Point(499, 11);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 28;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // textBox_codigo
            // 
            textBox_codigo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_codigo.Location = new Point(124, 198);
            textBox_codigo.Name = "textBox_codigo";
            textBox_codigo.PlaceholderText = "Código";
            textBox_codigo.ReadOnly = true;
            textBox_codigo.Size = new Size(100, 27);
            textBox_codigo.TabIndex = 27;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(30, 198);
            label5.Name = "label5";
            label5.Size = new Size(58, 24);
            label5.TabIndex = 26;
            label5.Text = "Código";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listBox_marca
            // 
            listBox_marca.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox_marca.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox_marca.FormattingEnabled = true;
            listBox_marca.ItemHeight = 20;
            listBox_marca.Location = new Point(124, 135);
            listBox_marca.Name = "listBox_marca";
            listBox_marca.Size = new Size(100, 24);
            listBox_marca.TabIndex = 25;
            // 
            // textBox_preco
            // 
            textBox_preco.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_preco.ForeColor = SystemColors.WindowText;
            textBox_preco.Location = new Point(124, 165);
            textBox_preco.Name = "textBox_preco";
            textBox_preco.PlaceholderText = "Preço";
            textBox_preco.Size = new Size(83, 27);
            textBox_preco.TabIndex = 24;
            textBox_preco.Text = "0,00";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(30, 165);
            label6.Name = "label6";
            label6.Size = new Size(58, 24);
            label6.TabIndex = 23;
            label6.Text = "Preço";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(30, 135);
            label4.Name = "label4";
            label4.Size = new Size(58, 24);
            label4.TabIndex = 19;
            label4.Text = "Marca";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(30, 105);
            label3.Name = "label3";
            label3.Size = new Size(81, 24);
            label3.TabIndex = 17;
            label3.Text = "SubCategoria";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listBox_subcategoria
            // 
            listBox_subcategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox_subcategoria.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox_subcategoria.FormattingEnabled = true;
            listBox_subcategoria.ItemHeight = 20;
            listBox_subcategoria.Location = new Point(124, 105);
            listBox_subcategoria.Name = "listBox_subcategoria";
            listBox_subcategoria.Size = new Size(100, 24);
            listBox_subcategoria.TabIndex = 16;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(30, 75);
            label2.Name = "label2";
            label2.Size = new Size(58, 24);
            label2.TabIndex = 15;
            label2.Text = "Cor";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listBox_cor
            // 
            listBox_cor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox_cor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox_cor.FormattingEnabled = true;
            listBox_cor.ItemHeight = 20;
            listBox_cor.Location = new Point(124, 75);
            listBox_cor.Name = "listBox_cor";
            listBox_cor.Size = new Size(100, 24);
            listBox_cor.TabIndex = 14;
            // 
            // label_categoria
            // 
            label_categoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_categoria.Font = new Font("Segoe UI", 9F);
            label_categoria.Location = new Point(30, 10);
            label_categoria.Name = "label_categoria";
            label_categoria.Size = new Size(58, 24);
            label_categoria.TabIndex = 12;
            label_categoria.Text = "Categoria";
            label_categoria.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listBox_categoria
            // 
            listBox_categoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox_categoria.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox_categoria.FormattingEnabled = true;
            listBox_categoria.ItemHeight = 20;
            listBox_categoria.Location = new Point(124, 10);
            listBox_categoria.Name = "listBox_categoria";
            listBox_categoria.Size = new Size(100, 24);
            listBox_categoria.TabIndex = 11;
            // 
            // textBox_descricao
            // 
            textBox_descricao.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_descricao.Location = new Point(124, 40);
            textBox_descricao.Name = "textBox_descricao";
            textBox_descricao.PlaceholderText = "Descrição";
            textBox_descricao.Size = new Size(252, 27);
            textBox_descricao.TabIndex = 10;
            // 
            // label_descricao
            // 
            label_descricao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_descricao.Font = new Font("Segoe UI", 9F);
            label_descricao.Location = new Point(204, 57);
            label_descricao.Name = "label_descricao";
            label_descricao.Size = new Size(0, 30);
            label_descricao.TabIndex = 9;
            label_descricao.Text = "Descrição";
            label_descricao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frm_cadastroproduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 320);
            Controls.Add(panel_cadastro);
            Controls.Add(panel_cabecalho);
            Name = "frm_cadastroproduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produtos";
            panel_cabecalho.ResumeLayout(false);
            panel_cabecalho.PerformLayout();
            panel_cadastro.ResumeLayout(false);
            panel_cadastro.PerformLayout();
            ResumeLayout(false);
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            int categoria = listBox_categoria.SelectedIndex * -1;
            string descricao = textBox_descricao.Text;
            int cor = listBox_cor.SelectedIndex * -1;
            int subCategoria = listBox_subcategoria.SelectedIndex * -1;
            int marca = listBox_marca.SelectedIndex * -1;
            double preco = Convert.ToDouble(textBox_preco.Text);
            

            

            if (descricao == "" || descricao == null)
            {
                MessageBox.Show("Todos os campos são obrigatórios!");
            }

            else 
            {
                var codigoProduto = await _produtoService.GeraCodigoProdutoAutomatico(marca, cor, categoria);
                textBox_codigo.Text = Convert.ToString(codigoProduto);
                ProdutoCommand command = new ProdutoCommand()
                {
                    codigoProduto = codigoProduto,
                    descricao = descricao,
                    precoProduto = Convert.ToDecimal(preco),
                    categoria = (Domain.Enums.ECategoria)categoria,
                    subCategoria = (Domain.Enums.ESubCategoria)subCategoria,
                    marca = (Domain.Enums.EMarca)marca,
                    cor = (Domain.Enums.ECor)cor,
                };           
            
                await _produtoService.PostAsync(command);
                MessageBox.Show("Produto Cadastrado com sucesso");
                textBox_descricao.Text = "";
                textBox_descricao.PlaceholderText = "Descrição";
                textBox_preco.Text = "0,00";
                textBox_codigo.Text = "";
                textBox_codigo.PlaceholderText = "Código";
            }
        }

        #endregion

        private Panel panel_cabecalho;
        private Label label_cabecalho;
        private Panel panel_cadastro;
        private TextBox textBox_descricao;
        private Label label_descricao;
        private Label label_categoria;
        private ListBox listBox_categoria;
        private Label label4;
        private Label label3;
        private ListBox listBox_subcategoria;
        private Label label2;
        private ListBox listBox_cor;
        private TextBox textBox_preco;
        private Label label6;
        private TextBox textBox_codigo;
        private Label label5;
        private ListBox listBox_marca;
        private Button btnSalvar;
        private Label label1;
    }
}
