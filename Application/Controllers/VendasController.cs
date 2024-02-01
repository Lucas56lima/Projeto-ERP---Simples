using Domain.Interface;
using Domain.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Services;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendasController : ControllerBase
    {
        private readonly IVendasService _vendasService;

        public VendasController(IVendasService vendasService)
        {
            _vendasService = vendasService;
        }

        [HttpPost]
        [Route("Vendas")]

        public async Task<IActionResult> PostVendaAsync([FromBody] VendaViewModel venda)
        {
            return Ok(await _vendasService.PostVendaAsync(venda));
        }

    }
}
