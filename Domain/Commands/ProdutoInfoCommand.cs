namespace Domain.Commands
{
    public class ProdutoInfoCommand
    {
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Total { get; set; }
        public decimal PrecoProduto { get; set; }
    }
}
