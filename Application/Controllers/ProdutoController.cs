using Domain.Commands;
using Domain.Interface;
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

        [HttpPut]
        [Route("AtualizarProduto")]

        public async Task<IActionResult> UpdateProdutoAsync(int codigoProduto, [FromBody] ProdutoCommand command)
        {
            return Ok(await _produtoService.UpdateProdutoAsync(codigoProduto,command));
        }

        [HttpGet]
        [Route("ListaProdutos")]

        public async Task<IActionResult> GetAsyncList()
        {
            return Ok(await _produtoService.GetAsyncList());
        }

        [HttpGet]
        [Route("FiltrarProduto")]

        public async Task<IActionResult> GetAsyncProduto(int codigoProduto,string?descricao)
        {
            return Ok(await _produtoService.GetAsyncProduto(codigoProduto,descricao));
        }

    }
}
