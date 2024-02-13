using Domain.Interface;
using Domain.ViewModel;

namespace Service.Services
{
    public class VendasService
    {
        private readonly IVendasRepository _repository;

        public VendasService(IVendasRepository repository)
        {
            _repository = repository;
        }
        public async Task<string> PostVendaAsync(VendaViewModel venda)
        {
            if (venda == null)
            {
                return null;
            }


            return await _repository.PostVendaAsync(venda);
        }
    }
}
