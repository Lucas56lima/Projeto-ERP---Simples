using Domain.Commands;
using Domain.Interface;
using Domain.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpPost]
        [Route("CadastrarProduto")]

        public async Task<IActionResult> PostAsync([FromBody] ProdutoCommand command)
        {
            return Ok(await _produtoService.PostAsync(command));
        }

        [HttpPost]
        [Route("Vendas")]

        public async Task<IActionResult> PostVendaAsync([FromBody] VendaViewModel venda)
        {
            return Ok(await _produtoService.PostVendaAsync(venda));
        }

        [HttpPut]
        [Route("AtualizarEstoque")]

        public async Task<IActionResult> PutEstoqueAsync(EstoqueCommand estoque)
        {
            return Ok(await _produtoService.PutEstoqueAsync(estoque));
        }

    }
}
