using System;
using System.Windows.Forms;
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
                frmConsultarProduto.ShowDialog();
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
                dataGridView2.Rows.Add(codigo, descricao, valor, marca, cor, 1);
                MessageBox.Show("Item Adicionado com sucesso!");
                decimal total = 0;
                decimal quantidadeTotal = 0;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    // Verifica se a célula não está vazia e se o valor é numérico
                    if (row.Cells[2].Value != null && decimal.TryParse(row.Cells[2].Value.ToString(), out decimal value))
                    {
                        total += value;
                    }                    

                    textBox_total.Text = Convert.ToString(total);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada!");
            }
        }
    }
}
