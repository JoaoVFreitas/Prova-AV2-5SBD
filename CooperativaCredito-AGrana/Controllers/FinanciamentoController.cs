using CooperativaCredito_AGrana.Models;
using CooperativaCredito_AGrana.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CooperativaCredito_AGrana.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinanciamentoController : ControllerBase
    {
        private readonly IFinanciamentoRepositorio _financiamentoRepositorio;

        public FinanciamentoController(IFinanciamentoRepositorio financiamentoRepositorio)
        {
            _financiamentoRepositorio = financiamentoRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<FinanciamentoModel>>> BuscarTodosFinanciamentos()
        {
            List<FinanciamentoModel> financiamentos = await _financiamentoRepositorio.BuscarTodosFinanciamentos();
            return Ok(financiamentos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FinanciamentoModel>> BuscarPorId(int id)
        {
            FinanciamentoModel financiamento = await _financiamentoRepositorio.BuscarPorId(id);
            return Ok(financiamento);
        }

        [HttpPost]
        public async Task<ActionResult<FinanciamentoModel>> Cadastrar([FromBody] FinanciamentoModel financiamentoModel)
        {
            FinanciamentoModel financiamento = await _financiamentoRepositorio.Adicionar(financiamentoModel);
            return Ok(financiamento);
        }
    }
}