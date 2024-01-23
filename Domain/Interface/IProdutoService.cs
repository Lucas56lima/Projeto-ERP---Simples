using Domain.Commands;
using Domain.ViewModel;

namespace Domain.Interface
{
    public interface IProdutoService
    {
        Task<string> PostAsync(ProdutoCommand command);
        Task<string> PutEstoqueAsync(EstoqueCommand estoque);

        Task<string> PostVendaAsync(VendaViewModel venda);
    }
}
