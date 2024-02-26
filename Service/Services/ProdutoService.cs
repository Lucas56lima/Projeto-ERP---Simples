using Domain.Commands;
using Domain.Interface;

namespace Service.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;
        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }
        public async Task<int> GeraCodigoProdutoAutomatico(string marca, string cor, string categoria)
        {
            return await _repository.GeraCodigoProdutoAutomatico(marca,cor,categoria);
        }
        public async Task<IEnumerable<ProdutoCommand>> GetAsyncList()
        {
            return await _repository.GetAsyncList();
        }
        public async Task<IEnumerable<ProdutoCommand>> GetAsyncProduto(int codigoProduto, string? descricao)
        {

            return await _repository.GetAsyncProduto(codigoProduto,descricao);
        }

        public async Task<IEnumerable<CategoriaCommand>> GetCategoria()
        {
            return await _repository.GetCategoria();
        }

        public async Task<IEnumerable<CorCommand>> GetCor()
        {
            return await _repository.GetCor();
        }

        public async Task<IEnumerable<MarcaCommand>> GetMarca()
        {
            return await _repository.GetMarca();
        }

        public async Task<IEnumerable<SubCategoriaCommand>> GetSubcategoria()
        {
            return await _repository.GetSubcategoria();
        }

        public async Task<string> PostAsync(ProdutoCommand command)
        {

            if (command == null)
            {
                return "Todos os campos são obrigatórios!";
            }
            return await _repository.PostAsync(command);
        }                       
        public async Task<string> UpdateProdutoAsync(int codigoProduto, ProdutoCommand command)
        {
            if (command == null)
            {
                return "Todos os campos são obrigatórios!";
            }
            return await _repository.UpdateProdutoAsync(codigoProduto, command);
        }        
    }
}

       
    

        
