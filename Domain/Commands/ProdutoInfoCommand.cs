using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Commands
{
    public class ProdutoInfoCommand
    {
        public int Quantidade { get; set; }
        public decimal Total { get; set; }
    }
}
