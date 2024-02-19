namespace Domain.Interface
{
    public interface IEstoqueService
    {
        Task<string> PutEstoqueAsync(EstoqueCommand estoque);
    }
}
