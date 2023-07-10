using CooperativaCredito_AGrana.Models;
using CooperativaCredito_AGrana.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CooperativaCredito_AGrana.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedorController : ControllerBase
    {
        private readonly IVendedorRepositorio _vendedorRepositorio;

        public VendedorController(IVendedorRepositorio vendedorRepositorio)
        {
            _vendedorRepositorio = vendedorRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<VendedorModel>>> BuscarTodosVendedores()
        {
            List<VendedorModel> vendedors = await _vendedorRepositorio.BuscarTodosVendedores();
            return Ok(vendedors);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<VendedorModel>> BuscarPorId(int id)
        {
            VendedorModel vendedor = await _vendedorRepositorio.BuscarPorId(id);
            return Ok(vendedor);
        }

        [HttpPost]
        public async Task<ActionResult<VendedorModel>> Cadastrar([FromBody] VendedorModel vendedorModel)
        {
            VendedorModel vendedor = await _vendedorRepositorio.Adicionar(vendedorModel);
            return Ok(vendedor);
        }
    }
}
