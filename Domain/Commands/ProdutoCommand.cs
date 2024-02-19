using Domain.Enums;

namespace Domain.Commands
{
    public class ProdutoCommand
    {    
        public int codigoProduto {  get; set; }
        public string descricao { get; set; }
        public decimal precoProduto { get; set; }
        public ECategoria categoria { get; set; }
        public ESubCategoria subCategoria { get; set; }
        public EMarca marca { get; set; }
        public ECor cor { get; set; }

    } 
          
}   
