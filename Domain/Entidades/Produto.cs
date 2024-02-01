using Domain.Enums;

namespace Domain.Entidades
{
    public class Produto
    {

        public int codigoProduto { get; set; }
        public string descricao { get; set; }        
        public decimal precoProduto { get; set; }
        public ECategoria categoria { get; set; }
        public ESubCategoria subCategoria { get; set; }
        public EMarca marca { get; set; }
        public ECor cor { get; set; }

    }

    public class Estoque
    {
        public string documento { get; set; }

        public decimal valorUnitario { get; set; }
        public int quantidade { get; set; }
    }
}
