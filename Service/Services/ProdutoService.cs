using Domain.Commands;
using Domain.Interface;
using Infrastructure.Repository;

namespace Service.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ProdutoCommandConsulta>> GetAsyncList()
        {
            return await _repository.GetAsyncList();
        }

        public async Task<IEnumerable<ProdutoCommandConsulta>> GetAsyncProduto(int codigoProduto, string descricao)
        {
            return await _repository.GetAsyncProduto(codigoProduto,descricao);
        }

        public async Task<string> PostAsync(ProdutoCommand command)
        {

            if (command == null)
            {
                return "Todos os campos são obrigatórios!";
            }
            return await _repository.PostAsync(command);
        }

        

        public async Task<string> PutAsync(int codigoProduto, ProdutoCommand command)
        {
            if (command == null)
            {
                return "Todos os campos são obrigatórios!";
            }
            return await _repository.PutAsync(codigoProduto, command);
        }
    }
}

       
    

        
