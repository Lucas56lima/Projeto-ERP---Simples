using InterfaceGui.InterfaceProduto;

namespace InterfaceGui
{
    public partial class frm_telainicial
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
            
            panel1 = new Panel();
            label1 = new Label();
            panel_inicial = new Panel();
            flowmodulos = new FlowLayoutPanel();
            btnFaturamento = new Button();
            btnEstoque = new Button();
            btnCadastros = new Button();
            panel_modulo = new Panel();
            label_modulo = new Label();
            panel_iniciorapido = new Panel();
            Inicio = new Label();
            flow_iniciorapido = new FlowLayoutPanel();
            btnPdv = new Button();
            btnConsultaPreco = new Button();
            btnProdutos = new Button();
            btnFecharCx = new Button();
            btnAbrirCaixa = new Button();
            panel1.SuspendLayout();
            panel_inicial.SuspendLayout();
            flowmodulos.SuspendLayout();
            panel_modulo.SuspendLayout();
            panel_iniciorapido.SuspendLayout();
            flow_iniciorapido.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 44, 58);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1363, 768);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(32, 28);
            label1.Name = "label1";
            label1.Size = new Size(146, 26);
            label1.TabIndex = 0;
            label1.Text = "EASY CASH";
            // 
            // panel_inicial
            // 
            panel_inicial.BackColor = Color.FromArgb(197, 212, 230);
            panel_inicial.Controls.Add(flowmodulos);
            panel_inicial.Controls.Add(panel_modulo);
            panel_inicial.Controls.Add(panel_iniciorapido);
            panel_inicial.Controls.Add(flow_iniciorapido);
            panel_inicial.Location = new Point(1, 91);
            panel_inicial.Name = "panel_inicial";
            panel_inicial.Size = new Size(1366, 768);
            panel_inicial.TabIndex = 1;
            // 
            // flowmodulos
            // 
            flowmodulos.BorderStyle = BorderStyle.Fixed3D;
            flowmodulos.Controls.Add(btnFaturamento);
            flowmodulos.Controls.Add(btnEstoque);
            flowmodulos.Controls.Add(btnCadastros);
            flowmodulos.Location = new Point(476, 45);
            flowmodulos.Name = "flowmodulos";
            flowmodulos.Size = new Size(885, 312);
            flowmodulos.TabIndex = 1;
            // 
            // btnFaturamento
            // 
            btnFaturamento.BackColor = Color.SteelBlue;
            btnFaturamento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFaturamento.Location = new Point(3, 3);
            btnFaturamento.Name = "btnFaturamento";
            btnFaturamento.Size = new Size(165, 73);
            btnFaturamento.TabIndex = 2;
            btnFaturamento.Text = "Faturamento";
            btnFaturamento.UseVisualStyleBackColor = false;
            btnFaturamento.Click += btnFaturamento_Click;
            // 
            // btnEstoque
            // 
            btnEstoque.BackColor = Color.SteelBlue;
            btnEstoque.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEstoque.Location = new Point(174, 3);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(165, 73);
            btnEstoque.TabIndex = 3;
            btnEstoque.Text = "Estoque";
            btnEstoque.UseVisualStyleBackColor = false;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // btnCadastros
            // 
            btnCadastros.BackColor = Color.SteelBlue;
            btnCadastros.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastros.Location = new Point(345, 3);
            btnCadastros.Name = "btnCadastros";
            btnCadastros.Size = new Size(165, 73);
            btnCadastros.TabIndex = 4;
            btnCadastros.Text = "Cadastros Gerais";
            btnCadastros.UseVisualStyleBackColor = false;
            btnCadastros.Click += btnCadastros_Click;
            // 
            // panel_modulo
            // 
            panel_modulo.BorderStyle = BorderStyle.Fixed3D;
            panel_modulo.Controls.Add(label_modulo);
            panel_modulo.Location = new Point(476, 3);
            panel_modulo.Name = "panel_modulo";
            panel_modulo.Size = new Size(885, 39);
            panel_modulo.TabIndex = 2;
            // 
            // label_modulo
            // 
            label_modulo.AutoSize = true;
            label_modulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_modulo.Location = new Point(208, 6);
            label_modulo.Name = "label_modulo";
            label_modulo.Size = new Size(100, 30);
            label_modulo.TabIndex = 1;
            label_modulo.Text = "Módulos";
            // 
            // panel_iniciorapido
            // 
            panel_iniciorapido.BorderStyle = BorderStyle.Fixed3D;
            panel_iniciorapido.Controls.Add(Inicio);
            panel_iniciorapido.Location = new Point(0, 3);
            panel_iniciorapido.Name = "panel_iniciorapido";
            panel_iniciorapido.Size = new Size(435, 39);
            panel_iniciorapido.TabIndex = 1;
            // 
            // Inicio
            // 
            Inicio.AutoSize = true;
            Inicio.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Inicio.Location = new Point(123, 3);
            Inicio.Name = "Inicio";
            Inicio.Size = new Size(144, 30);
            Inicio.TabIndex = 0;
            Inicio.Text = "Início Rápido";
            // 
            // flow_iniciorapido
            // 
            flow_iniciorapido.BorderStyle = BorderStyle.Fixed3D;
            flow_iniciorapido.Controls.Add(btnPdv);
            flow_iniciorapido.Controls.Add(btnConsultaPreco);
            flow_iniciorapido.Controls.Add(btnProdutos);
            flow_iniciorapido.Controls.Add(btnFecharCx);
            flow_iniciorapido.Controls.Add(btnAbrirCaixa);
            flow_iniciorapido.Location = new Point(0, 45);
            flow_iniciorapido.Name = "flow_iniciorapido";
            flow_iniciorapido.Size = new Size(435, 312);
            flow_iniciorapido.TabIndex = 0;
            // 
            // btnPdv
            // 
            btnPdv.BackColor = Color.SteelBlue;
            btnPdv.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPdv.Image = Properties.Resources.sale_icon2;
            btnPdv.ImageAlign = ContentAlignment.TopLeft;
            btnPdv.Location = new Point(3, 3);
            btnPdv.Name = "btnPdv";
            btnPdv.Size = new Size(204, 85);
            btnPdv.TabIndex = 0;
            btnPdv.Text = "       Ponto de Venda";
            btnPdv.UseVisualStyleBackColor = false;
            btnPdv.Click += btnPdv_Click;
            // 
            // btnConsultaPreco
            // 
            btnConsultaPreco.BackColor = Color.SteelBlue;
            btnConsultaPreco.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultaPreco.Location = new Point(213, 3);
            btnConsultaPreco.Name = "btnConsultaPreco";
            btnConsultaPreco.Size = new Size(204, 85);
            btnConsultaPreco.TabIndex = 1;
            btnConsultaPreco.Text = "Consultar Preço";
            btnConsultaPreco.UseVisualStyleBackColor = false;
            btnConsultaPreco.Click += BtnConsultaPreco_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = Color.SteelBlue;
            btnProdutos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProdutos.Location = new Point(3, 94);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(204, 85);
            btnProdutos.TabIndex = 2;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnFecharCx
            // 
            btnFecharCx.BackColor = Color.SteelBlue;
            btnFecharCx.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFecharCx.Location = new Point(213, 94);
            btnFecharCx.Name = "btnFecharCx";
            btnFecharCx.Size = new Size(99, 85);
            btnFecharCx.TabIndex = 3;
            btnFecharCx.Text = "Fechar Caixa";
            btnFecharCx.UseVisualStyleBackColor = false;
            btnFecharCx.Click += btnFecharCx_Click;
            // 
            // btnAbrirCaixa
            // 
            btnAbrirCaixa.BackColor = Color.SteelBlue;
            btnAbrirCaixa.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAbrirCaixa.Location = new Point(318, 94);
            btnAbrirCaixa.Name = "btnAbrirCaixa";
            btnAbrirCaixa.Size = new Size(99, 85);
            btnAbrirCaixa.TabIndex = 4;
            btnAbrirCaixa.Text = "Abrir Caixa";
            btnAbrirCaixa.UseVisualStyleBackColor = false;
            btnAbrirCaixa.Click += btnAbrirCaixa_Click;
            // 
            // frm_telainicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 534);
            Controls.Add(panel_inicial);
            Controls.Add(panel1);
            Name = "frm_telainicial";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Easy Cash";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_inicial.ResumeLayout(false);
            flowmodulos.ResumeLayout(false);
            panel_modulo.ResumeLayout(false);
            panel_modulo.PerformLayout();
            panel_iniciorapido.ResumeLayout(false);
            panel_iniciorapido.PerformLayout();
            flow_iniciorapido.ResumeLayout(false);
            ResumeLayout(false);
        }
        

        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnFecharCx_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void btnProdutos_Click(object sender, EventArgs e)
        {

             using(frm_consultarproduto frmProduto = new frm_consultarproduto(_produtoService))
            {
                frmProduto.ShowDialog();
            }; 
            
        }

        private void BtnConsultaPreco_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            label_modulo.Text = "Módulo - Cadastros";          

            btnCadastrarLoja = new Button();
            btnCadastrarLoja.BackColor = Color.SteelBlue;
            btnCadastrarLoja.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrarLoja.Location = new Point(345, 3);
            btnCadastrarLoja.Name = "btnCadastrarLoja";
            btnCadastrarLoja.Size = new Size(165, 73);
            btnCadastrarLoja.TabIndex = 4;
            btnCadastrarLoja.Text = "Cadastro loja";
            btnCadastrarLoja.UseVisualStyleBackColor = false;

            btnCadastrarUsuario = new Button();
            btnCadastrarUsuario.BackColor = Color.SteelBlue;
            btnCadastrarUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrarUsuario.Location = new Point(345, 3);
            btnCadastrarUsuario.Name = "btnCadastrarUsuário";
            btnCadastrarUsuario.Size = new Size(165, 73);
            btnCadastrarUsuario.TabIndex = 4;
            btnCadastrarUsuario.Text = "Cadastro Usuário";
            btnCadastrarUsuario.UseVisualStyleBackColor = false;

            btnCadastrarProduto = new Button();
            btnCadastrarProduto.BackColor = Color.SteelBlue;
            btnCadastrarProduto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrarProduto.Location = new Point(345, 3);
            btnCadastrarProduto.Name = "btnCadastrarProduto";
            btnCadastrarProduto.Size = new Size(165, 73);
            btnCadastrarProduto.TabIndex = 4;
            btnCadastrarProduto.Text = "Cadastro Produto";
            btnCadastrarProduto.UseVisualStyleBackColor = false;
            btnCadastrarProduto.Click += BtnCadastrarProduto_Click; 
            flowmodulos.Controls.Clear();            
            flowmodulos.Controls.Add(btnCadastrarLoja);
            flowmodulos.Controls.Add(btnCadastrarUsuario);
            flowmodulos.Controls.Add(btnCadastrarProduto);
            CriaVoltarButton();
            flowmodulos.TabIndex = 1;
        }

        private void BtnCadastrarProduto_Click(object sender, EventArgs e)
        {
            using (frm_cadastroproduto frmCadastroProduto = new frm_cadastroproduto(_produtoService))
            {
                frmCadastroProduto.ShowDialog();
            };
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            label_modulo.Text = "Módulo - Estoque";

            btnMovimentarEstoque = new Button();
            btnMovimentarEstoque.BackColor = Color.SteelBlue;
            btnMovimentarEstoque.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMovimentarEstoque.Location = new Point(345, 3);
            btnMovimentarEstoque.Name = "btnmovimentarEstoque";
            btnMovimentarEstoque.Size = new Size(165, 73);
            btnMovimentarEstoque.TabIndex = 4;
            btnMovimentarEstoque.Text = "Movimentar Estoque";
            btnMovimentarEstoque.UseVisualStyleBackColor = false;

            btnRelatorioMov = new Button();
            btnRelatorioMov.BackColor = Color.SteelBlue;
            btnRelatorioMov.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelatorioMov.Location = new Point(345, 3);
            btnRelatorioMov.Name = "btnRelatorioMov";
            btnRelatorioMov.Size = new Size(165, 73);
            btnRelatorioMov.TabIndex = 4;
            btnRelatorioMov.Text = "Relatório Movimentações";
            btnRelatorioMov.UseVisualStyleBackColor = false;

            flowmodulos.Controls.Clear();

            
            flowmodulos.Controls.Add(btnMovimentarEstoque);
            flowmodulos.Controls.Add(btnRelatorioMov);
            CriaVoltarButton();
            flowmodulos.TabIndex = 1;
        }

        private void btnPdv_Click(object sender, EventArgs e)
        {
            using (frm_pdv frmPdv = new frm_pdv(_produtoService)) 
            {
                frmPdv.ShowDialog();
            }
        }

       

        private void btnFaturamento_Click(object sender, EventArgs e) {
            
            
            label_modulo.Text = "Módulo - Faturamento";
            
            btnRelatorioFat = new Button();
            btnRelatorioFat.BackColor = Color.SteelBlue;
            btnRelatorioFat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelatorioFat.Location = new Point(345, 3);
            btnRelatorioFat.Name = "btnRelatorioFat";
            btnRelatorioFat.Size = new Size(165, 73);
            btnRelatorioFat.TabIndex = 4;
            btnRelatorioFat.Text = "Relatório Faturamento";
            btnRelatorioFat.UseVisualStyleBackColor = false;        
                      
            flowmodulos.Controls.Clear();            
            flowmodulos.Controls.Add(btnRelatorioFat);
            btnRelatorioFat.Click += this.btnRelatorioFat_Click;
            CriaVoltarButton();
            flowmodulos.TabIndex = 1;

        }

        private void btnRelatorioFat_Click(object sender, EventArgs e)
        {
            frm_filtroRelatorioFat frmFiltroRelatorioFat = new frm_filtroRelatorioFat();

            frmFiltroRelatorioFat.ShowDialog();
        }

        private void CriaVoltarButton() {
            btnVoltar = new Button();
            btnVoltar.BackColor = Color.GhostWhite;
            btnVoltar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(345, 3);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(165, 73);
            btnVoltar.TabIndex = 4;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += this.btnVoltar_Click;

            flowmodulos.Controls.Add(btnVoltar);

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            flowmodulos.Controls.Clear();

            // 
            // btnFaturamento
            // 
            label_modulo.Text = "Módulos";
            btnFaturamento.BackColor = Color.SteelBlue;
            btnFaturamento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFaturamento.Location = new Point(3, 3);
            btnFaturamento.Name = "btnFaturamento";
            btnFaturamento.Size = new Size(165, 73);
            btnFaturamento.TabIndex = 2;
            btnFaturamento.Text = "Faturamento";
            btnFaturamento.UseVisualStyleBackColor = false;
            btnFaturamento.Click += this.btnFaturamento_Click;
            //
            //btnEstoque
            //

            btnEstoque.BackColor = Color.SteelBlue;
            btnEstoque.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEstoque.Location = new Point(174, 3);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(165, 73);
            btnEstoque.TabIndex = 3;
            btnEstoque.Text = "Estoque";
            btnEstoque.UseVisualStyleBackColor = false;
            btnEstoque.Click += this.btnEstoque_Click;
            // 
            // btnCadastros
            // 
            btnCadastros.BackColor = Color.SteelBlue;
            btnCadastros.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastros.Location = new Point(345, 3);
            btnCadastros.Name = "btnCadastros";
            btnCadastros.Size = new Size(165, 73);
            btnCadastros.TabIndex = 4;
            btnCadastros.Text = "Cadastros Gerais";
            btnCadastros.UseVisualStyleBackColor = false;
            btnCadastros.Click += this.btnCadastros_Click;            
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = Color.SteelBlue;
            btnProdutos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProdutos.Location = new Point(3, 94);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(204, 85);
            btnProdutos.TabIndex = 2;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += this.btnProdutos_Click;

            flowmodulos.Controls.Add(btnFaturamento);
            flowmodulos.Controls.Add(btnEstoque);
            flowmodulos.Controls.Add(btnCadastros);
            
            flowmodulos.TabIndex = 1;
        }



        #endregion

        private Panel panel1;
        private Panel panel_inicial;
        private FlowLayoutPanel flow_iniciorapido;
        private Button btnPdv;
        private Button btnConsultaPreco;
        private Button btnProdutos;
        private Button btnFecharCx;
        private Button btnAbrirCaixa;
        private Panel panel_iniciorapido;
        private FlowLayoutPanel flowmodulos;
        private Button btnFaturamento;
        private Button btnEstoque;
        private Button btnCadastros;
        private Button btnMovimentarEstoque;
        private Button btnRelatorioMov;
        private Button btnCadastrarLoja;
        private Button btnCadastrarUsuario;
        private Button btnCadastrarProduto;
        private Button btnVoltar;
        private Panel panel_modulo;
        private Label Inicio;
        private Label label_modulo;
        private Button btnRelatorioFat;
        private Control label_cabecalho;
        private Label label1;

        public PaintEventHandler panel_inicial_Paint { get; private set; }
        public PaintEventHandler flow_iniciorapido_Paint { get; private set; }
    }
}