using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModel
{
    internal class ConsultaVendasViewModel
    {
        public DateTime dataInicial {  get; set; }
        public DateTime dataFinal { get; set; }
        public string situacao {  get; set; }
    }
}
