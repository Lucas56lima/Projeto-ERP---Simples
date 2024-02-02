using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.ViewModel;

namespace Domain.Interface
{
    public interface IVendasRepository
    {
        Task<string> PostVendaAsync(VendaViewModel venda);
        Task<bool> VerificaQuantidade(int qtdInserida, int qtdDisponivel);
        
    }
}
