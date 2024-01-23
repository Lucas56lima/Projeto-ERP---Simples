using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Commands;
using Domain.Interface;
using Domain.ViewModel;

namespace Service.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> PostAsync(ProdutoCommand command)
        {

            if (command == null)
            {
                return "Todos os campos são obrigatórios!";
            }
            return await _repository.PostAsync(command);
        }

        public async Task<string> PostVendaAsync(VendaViewModel venda)
        {
            if (venda == null)
            {
                return null;
            }
            return await _repository.PostVendaAsync(venda);
        }

        public async Task<string> PutEstoqueAsync(EstoqueCommand estoque)
        {
            if (estoque == null)
            {
                return "Todos os campos são obrigatórios!";
            }
            return await _repository.PutEstoqueAsync(estoque);
        }

        
    }

  
}
