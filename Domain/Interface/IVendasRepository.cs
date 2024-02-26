using Domain.ViewModel;

namespace Domain.Interface
{
    public interface IVendasRepository
    {
        Task<string> PostVendaAsync(VendaViewModel venda);
        Task<bool> VerificaQuantidade(int qtdInserida, int qtdDisponivel);
        
    }
}
