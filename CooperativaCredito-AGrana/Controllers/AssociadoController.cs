using CooperativaCredito_AGrana.Models;
using CooperativaCredito_AGrana.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CooperativaCredito_AGrana.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssociadoController : ControllerBase
    {
        private readonly IAssociadoRepositorio _associadoRepositorio;

        public AssociadoController(IAssociadoRepositorio associadoRepositorio)
        {
            _associadoRepositorio = associadoRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<AssociadoModel>>> BuscarTodosAssociados()
        {
            List<AssociadoModel> associados = await _associadoRepositorio.BuscarTodosAssociados();
            return Ok(associados);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AssociadoModel>> BuscarPorId(int id)
        {
            AssociadoModel associado = await _associadoRepositorio.BuscarPorId(id);
            return Ok(associado);
        }

        [HttpPost]
        public async Task<ActionResult<AssociadoModel>> Cadastrar([FromBody] AssociadoModel associadoModel)
        {
            AssociadoModel associado = await _associadoRepositorio.Adicionar(associadoModel);
            return Ok(associado);
        }
    }
}
