using Domain.Commands;

namespace Domain.ViewModel
{
    public class VendaViewModel
    {
        public int Produto { get; set; }
        public ProdutoInfoCommand PrecoProduto { get; set; }
        public int quantidade { get; set; }
        public DateTime data { get; set; }

        public string CodTransacao { get; set; }
        
        public int documento { get; set; }
        public int serie {get; set; }
        public decimal valorTotal {get; set; }

        public string CodPagamento { get; set; }
        public string CodOperadora { get; set; }

    }
}
