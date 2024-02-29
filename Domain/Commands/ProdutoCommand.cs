namespace Domain.Commands
{
    public class ProdutoCommand
    {
        public int codigoProduto { get; set; }
        public string descricao { get; set; }
        public decimal precoProduto { get; set; }
        public int categoria { get; set; }
        public int subCategoria { get; set; }
        public int marca { get; set; }
        public int cor { get; set; }
        public int quantidade {  get; set; }
    }           
}   
