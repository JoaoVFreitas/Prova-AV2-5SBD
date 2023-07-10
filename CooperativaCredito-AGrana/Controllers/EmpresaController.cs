using CooperativaCredito_AGrana.Models;
using CooperativaCredito_AGrana.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CooperativaCredito_AGrana.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        private readonly IEmpresaRepositorio _empresaRepositorio;

        public EmpresaController(IEmpresaRepositorio empresaRepositorio)
        {
            _empresaRepositorio = empresaRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<EmpresaModel>>> BuscarTodasEmpresas()
        {
            List<EmpresaModel> empresas = await _empresaRepositorio.BuscarTodasEmpresas();
            return Ok(empresas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EmpresaModel>> BuscarPorId(int id)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarPorId(id);
            return Ok(empresa);
        }

        [HttpPost]
        public async Task<ActionResult<EmpresaModel>> Cadastrar([FromBody] EmpresaModel empresaModel)
        {
            EmpresaModel empresa = await _empresaRepositorio.Adicionar(empresaModel);
            return Ok(empresa);
        }
    }
}