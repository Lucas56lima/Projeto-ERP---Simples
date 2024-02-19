using Domain.Interface;
using InterfaceGui.InterfaceProduto;

namespace InterfaceGui
{
    public partial class frm_pdv : Form
    {
        private readonly IProdutoService _produtoService;
        public DataGridView DataGridViewReference { get; set; }
        public frm_pdv(IProdutoService produtoService)
        {
            _produtoService = produtoService;            
            InitializeComponent();
        }       
        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            using (frm_consultarproduto frmConsultarProduto = new frm_consultarproduto(_produtoService))
            {
                frmConsultarProduto.btn_selecionar.Visible = true;
                frmConsultarProduto.btn_selecionar.Click += (s, ev) => Btn_selecionar_Click(frmConsultarProduto.dataGridView1.CurrentRow);
                dataGridView2.CellValueChanged += DataGridView2_CellValueChanged;
                textBox_divisao.TextChanged += TextBox_divisao_TextChanged;
                textBox_desconto.TextChanged += TextBox_desconto_TextChanged;
                frmConsultarProduto.ShowDialog();
            }
        }
        private void TextBox_desconto_TextChanged(object? sender, EventArgs e)
        {
            decimal total;
            decimal totalComDesconto;
            total = Convert.ToDecimal(textBox_total.Text);
            if (!string.IsNullOrEmpty(textBox_desconto.Text))
            {
                decimal desconto;
                if (decimal.TryParse(textBox_desconto.Text, out desconto))
                {
                    if (desconto > 0)
                    {                        
                        totalComDesconto =  total - desconto;
                        textBox_total.Text = totalComDesconto.ToString("0.00");
                    }
                    
                    if(desconto == 0)
                    {
                        SomaValores();
                    }
                }
                else
                {
                    MessageBox.Show("Insira um valor válido!");
                }
            }
        }
        private void TextBox_divisao_TextChanged(object? sender, EventArgs e)
        {            
            if(textBox_divisao.Text != null && textBox_divisao.Text != "" && Convert.ToInt32(textBox_divisao.Text) > 0) 
            {
                int divisao = Convert.ToInt32(textBox_divisao.Text);
                decimal total = Convert.ToDecimal(textBox_total.Text);
                textBox_resultado.Text = (total / divisao).ToString("0.00");
            }
            else
            {
                MessageBox.Show("Insira um valor Válido!");
            }
        }       
        private void Btn_selecionar_Click(DataGridViewRow selectedRow)
        {
            if (selectedRow != null)
            {
                string codigo = selectedRow.Cells["codigoProduto"].Value.ToString();
                string descricao = selectedRow.Cells["descricao"].Value.ToString();
                decimal valor = Convert.ToDecimal(selectedRow.Cells["precoProduto"].Value);
                string marca = selectedRow.Cells["marca"].Value.ToString();
                string cor = selectedRow.Cells["cor"].Value.ToString();
                int quantidade = Convert.ToInt32(selectedRow.Cells["quantidade"].Value.ToString());
                if(quantidade > 0)
                {
                    int qtdDefault = 1;
                    dataGridView2.Rows.Add(codigo, descricao, valor, marca, cor, qtdDefault,valor*qtdDefault);
                    MessageBox.Show("Item Adicionado com sucesso!");                   
                    btnExcluir.Visible = true;
                    btnExcluir.Click += BtnExcluir_Click;
                    btnSelecionar.Visible = true;
                    btnSelecionar.Click +=BtnSelecionar_Click;
                    SomaValores();
                }
                else 
                {
                    MessageBox.Show("Sem estoque disponível!");
                }
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada!");
            }
        }      
        private void BtnSelecionar_Click(object? sender, EventArgs e)
        {            
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {                
                row.Selected = true;                              
            }            
        }      
        private void BtnExcluir_Click(object? sender, EventArgs e)
        {                                                                   
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.Remove(row);
            }
            SomaValores();
            
            if(dataGridView2.Rows.Count == 0)
            {
                textBox_total.Text = "0,00";
            }
        }
        private void DataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["quantidade"].Index)
            {
                decimal total = 0.00m;
                int quantidade = 0;
                decimal valorUn = 0;
                decimal totalProdutos = 0.00m;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells[2].Value != null && decimal.TryParse(row.Cells[2].Value.ToString(), out decimal value))
                    {
                        quantidade = Convert.ToInt32(row.Cells[5].Value);
                        valorUn = Convert.ToInt32(row.Cells[2].Value);
                        total = Convert.ToDecimal(quantidade * valorUn);
                        row.Cells[6].Value = total.ToString("0.00");
                        totalProdutos += Convert.ToDecimal(row.Cells[6].Value);
                    }
                    textBox_total.Text = totalProdutos.ToString("0.00");
                }
            }
        }
        private void SomaValores()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells[2].Value != null && decimal.TryParse(row.Cells[2].Value.ToString(), out decimal value))
                {
                    total += Convert.ToDecimal(row.Cells[6].Value);
                }                
                textBox_total.Text = total.ToString("0.00");
            }
        }
    }
}
