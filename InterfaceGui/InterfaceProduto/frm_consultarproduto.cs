using Domain.Interface;

namespace InterfaceGui.InterfaceProduto
{
    public partial class frm_consultarproduto : Form
    {
        private readonly IProdutoService _produtoService;
        public frm_consultarproduto(IProdutoService produtoService)
        {


            _produtoService = produtoService;
            InitializeComponent();
            PreencherDataGridView();
        }

        private async void PreencherDataGridView()
        {

            var produtos = await _produtoService.GetAsyncList();
            dataGridView1.DataSource = produtos;
            Column_produto.HeaderText = "Produto";
            Column_descricao.HeaderText = "Descrição";
            Column_preco.HeaderText = "Preço";
            
        }

    }
}
