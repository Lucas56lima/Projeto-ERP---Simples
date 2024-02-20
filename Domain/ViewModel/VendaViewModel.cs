using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Commands;
using Domain.Enums;

namespace Domain.ViewModel
{
    public class VendaViewModel
    {
        public int Produto { get; set; }
        public ProdutoInfoCommand PrecoProduto { get; set; }
        public int quantidade { get; set; }
        public DateTime data { get; set; }

        public ETransacoes CodTransacao { get; set; }
        
        public int documento { get; set; }
        public int serie {get; set; }
        public decimal valorTotal {get; set; }

        public EPagamentos CodPagamento { get; set; }
        public EOperadoras CodOperadora { get; set; }

    }
}
