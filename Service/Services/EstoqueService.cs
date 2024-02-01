using Domain.Commands;
using Domain.Interface;

namespace Service.Services
{
    public class EstoqueService
    {
        private readonly IEstoqueRepository _repository;

        public EstoqueService(IEstoqueRepository repository)
        {
            _repository = repository;
        }
        public async Task<string> PutEstoqueAsync(EstoqueCommand estoque)
        {
            if (estoque == null)
            {
                return "Todos os campos são obrigatórios!";
            }
            return await _repository.PutEstoqueAsync(estoque);
        }

        public Task<bool> VerificaQuantidade(int qtdInserida, int qtdDisponivel)
        {
            throw new NotImplementedException();
        }
    }

}

