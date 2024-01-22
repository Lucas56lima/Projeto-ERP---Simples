using Domain.Enums;

namespace Domain.Entidades
{
    public class Produto
    {
        
        public string descricao { get; set; }
        public decimal precoProduto { get; set; }
        public ECategoria categoria { get; set; }
        public ESubCategoria subCategoria { get; set; }
        public EMarca marca { get; set; }
        public ECor cor { get; set; }

    }
}
