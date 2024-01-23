using Domain.Enums;

namespace Domain.Commands
{
    public class ProdutoCommand
    {        
        public string descricao { get; set; }
        public decimal precoProduto { get; set; }
        public ECategoria categoria { get; set; }
        public ESubCategoria subCategoria { get; set; }
        public EMarca marca { get; set; }
        public ECor cor { get; set; }

    }

    public class EstoqueCommand
    {
        public int produto { get; set; } 
        public string documento { get; set; }
        public decimal valorUnitario { get; set; }
        public int quantidade { get; set; }
        
    }

}   
