using Domain.Commands;
using Domain.ViewModel;

namespace Domain.Interface
{
    public interface IProdutoRepository
    {
        Task<string> PostAsync(ProdutoCommand command);
        Task<string> PutAsync(int codigoProduto, ProdutoCommand command);
        Task<IEnumerable<ProdutoCommandConsulta>> GetAsyncList();
        Task<IEnumerable<ProdutoCommandConsulta>> GetAsyncProduto(int codigoProduto, string descricao);
    }
}
