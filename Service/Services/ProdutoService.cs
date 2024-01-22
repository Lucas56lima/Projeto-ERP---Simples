using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProdutoService
    {

    }

    public async Task<string> PostAsync(ProdutoCommand command)
    {

        if (command == null)
        {
            return "Todos os campos são obrigatórios!";
        }
    }
}
