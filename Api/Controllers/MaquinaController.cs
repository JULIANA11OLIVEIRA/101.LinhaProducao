using Application.Contracts.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaquinaController : ControllerBase
    {
        public readonly IFabricaService _fabricaService;

        public MaquinaController(IFabricaService fabricaService)
        {
            _fabricaService = fabricaService;
        }

        [HttpGet("buscar-por-filtro")]
        public string GetByFilter(string maquina, string tipo)
        {
            return _fabricaService.BuscarPorFiltro(maquina, tipo);
        }

        [HttpGet("buscar-por-maquina")]
        public string Get(string maquina)
        {
            return _fabricaService.BuscarPorMaquina(maquina);
        }
    }
}
