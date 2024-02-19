using System;
using System.Threading.Tasks;
using Domain.Interface;

namespace Service.Services
{
    public class EstoqueService : IEstoqueService
    {
        private readonly IEstoqueRepository _repository;

        public EstoqueService(IEstoqueRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<string> PutEstoqueAsync(EstoqueCommand estoque)
        {
            if (estoque == null)
            {
                throw new ArgumentNullException(nameof(estoque), "O estoque não pode estar vazio.");
            }

            if (estoque.quantidade <= 0)
            {
                throw new ArgumentException("A quantidade do estoque deve ser maior que zero.", nameof(estoque.quantidade));
            }

            try
            {
                return await _repository.PutEstoqueAsync(estoque);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Não foi possível atualizar o Estoque!", ex);
            }
        }      
    }
}
