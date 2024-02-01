using Domain.Commands;
using Domain.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstoqueController : ControllerBase
    {
        private readonly IEstoqueService _estoqueService;

        public EstoqueController(IEstoqueService estoqueService)
        {
            _estoqueService = estoqueService;
        } 

        [HttpPut]
        [Route("AtualizarEstoque")]

        public async Task<IActionResult> PutEstoqueAsync(EstoqueCommand estoque)
        {
            return Ok(await _estoqueService.PutEstoqueAsync(estoque));
        }

    }
}
