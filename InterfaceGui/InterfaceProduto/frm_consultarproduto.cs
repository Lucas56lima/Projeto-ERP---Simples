using Domain.Interface;

namespace InterfaceGui.InterfaceProduto
{
    public partial class frm_consultarproduto : Form
    {
        private readonly IProdutoService _produtoService;
        private frm_pdv frmPdv;
        public frm_consultarproduto(IProdutoService produtoService)
        {
            frmPdv = new frm_pdv(produtoService);
            frmPdv.DataGridViewReference = dataGridView1;
            _produtoService = produtoService;
            InitializeComponent();
            PreencherDataGridView();            
        }
        private async void PreencherDataGridView()
        {
            var produtos = await _produtoService.GetAsyncList();
            dataGridView1.DataSource = produtos;           
        }
    }
}
