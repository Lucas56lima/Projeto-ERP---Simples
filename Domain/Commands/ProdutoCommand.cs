namespace Domain.Commands
{
    public class ProdutoCommand
    {
        public int codigoProduto { get; set; }
        public string descricao { get; set; }
        public decimal precoProduto { get; set; }
        public string categoria { get; set; }
        public string subCategoria { get; set; }
        public string marca { get; set; }
        public string cor { get; set; }
        public int quantidade {  get; set; }
    }           
}   
