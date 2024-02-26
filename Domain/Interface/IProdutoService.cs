using Domain.Commands;
using Domain.ViewModel;

namespace Domain.Interface
{
    public interface IProdutoService
    {
        Task<string> PostAsync(ProdutoCommand command);
        Task<string> UpdateProdutoAsync(int codigoProduto, ProdutoCommand command);
        Task<IEnumerable<ProdutoCommand>> GetAsyncList();
        Task<IEnumerable<ProdutoCommand>> GetAsyncProduto(int codigoProduto,string? descricao);
        Task<int> GeraCodigoProdutoAutomatico(string marca, string cor, string categoria);
        Task<IEnumerable<MarcaCommand>> GetMarca();
        Task<IEnumerable<CorCommand>> GetCor();
        Task<IEnumerable<CategoriaCommand>> GetCategoria();
        Task<IEnumerable<SubCategoriaCommand>> GetSubcategoria();
    }
}
