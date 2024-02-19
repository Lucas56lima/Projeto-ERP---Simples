namespace Domain.Interface
{
    public interface IEstoqueRepository
    {
        Task<string> PutEstoqueAsync(EstoqueCommand estoque);
    }
}
