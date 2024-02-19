using Domain.Commands;

namespace Domain.Interface
{
    public interface IProdutoRepository
    {
        Task<string> PostAsync(ProdutoCommand command);
        Task<string> UpdateProdutoAsync(int codigoProduto, ProdutoCommand command);
        Task<IEnumerable<ProdutoCommand>> GetAsyncList();
        Task<IEnumerable<ProdutoCommand>> GetAsyncProduto(int codigoProduto, string? descricao);
        Task<int> GeraCodigoProdutoAutomatico(int marca, int cor,int categoria);        
    }
}
