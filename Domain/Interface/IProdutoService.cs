using Domain.Commands;

namespace Domain.Interface
{
    public interface IProdutoService
    {
        Task<string> PostAsync(ProdutoCommand command);
    }
}
