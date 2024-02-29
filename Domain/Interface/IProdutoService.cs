using Domain.Commands;
using Domain.Entidades;
using Domain.ViewModel;

namespace Domain.Interface
{
    public interface IProdutoService
    {
        Task<string> PostAsync(ProdutoCommand command);
        Task<string> UpdateProdutoAsync(int codigoProduto, ProdutoCommand command);
        Task<IEnumerable<ProdutoViewModel>> GetAsyncList();
        Task<IEnumerable<ProdutoViewModel>> GetAsyncProduto(int codigoProduto,string? descricao);
        Task<int> GeraCodigoProdutoAutomatico(int marca, int cor, int categoria);
        Task<IEnumerable<MarcaCommand>> GetMarca();
        Task<IEnumerable<CorCommand>> GetCor();
        Task<IEnumerable<CategoriaCommand>> GetCategoria();
        Task<IEnumerable<SubCategoriaCommand>> GetSubcategoria();
    }
}
