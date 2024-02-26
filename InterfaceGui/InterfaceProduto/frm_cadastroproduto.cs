using Domain.Interface;

namespace InterfaceGui.InterfaceProduto
{
    public partial class frm_cadastroproduto : Form
    {
        private readonly IProdutoService _produtoService;
        public frm_cadastroproduto(IProdutoService produtoService)
        {
            _produtoService = produtoService;
            InitializeComponent();
            PreencheCaracteristicas();
        }

        private async Task PreencheCaracteristicas()
        {
            var marcas = await _produtoService.GetMarca();
            foreach (var marca in marcas)
            {                
                string nomeMarca = marca.nomeMarca;
                listBox_marca.Items.Add(nomeMarca);
            }

            var cores = await _produtoService.GetCor();
            foreach (var cor in cores)
            {
                string nomeCor = cor.nomeCor;
                listBox_cor.Items.Add(nomeCor);
            }

            var categorias = await _produtoService.GetCategoria();
            foreach (var categoria in categorias)
            {
                string nomeCategoria = categoria.nomeCategoria;
                listBox_categoria.Items.Add(nomeCategoria);
            }

            var subCategorias = await _produtoService.GetSubcategoria();
            foreach (var subCategoria in subCategorias)
            {
                string nomeSubCategoria = subCategoria.nomeSubCategoria;
                listBox_subcategoria.Items.Add(nomeSubCategoria);
            }
        }
    }
}
