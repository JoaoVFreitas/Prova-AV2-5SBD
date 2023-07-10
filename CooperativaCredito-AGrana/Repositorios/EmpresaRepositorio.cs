using CooperativaCredito_AGrana.Data;
using CooperativaCredito_AGrana.Models;
using CooperativaCredito_AGrana.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CooperativaCredito_AGrana.Repositorios
{
    public class EmpresaRepositorio : IEmpresaRepositorio
    {
        private readonly AGranaDBContext _dbContext;
        public EmpresaRepositorio(AGranaDBContext aGranaDBContext)
        {
            _dbContext = aGranaDBContext;
        }
        public async Task<EmpresaModel> BuscarPorId(int id)
        {
            return await _dbContext.Empresas.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<EmpresaModel>> BuscarTodasEmpresas()
        {
            return await _dbContext.Empresas.ToListAsync();
        }
        public async Task<EmpresaModel> Adicionar(EmpresaModel empresa)
        {
            await _dbContext.Empresas.AddAsync(empresa);
            await _dbContext.SaveChangesAsync();

            return empresa;
        }

        public async Task<EmpresaModel> Atualizar(EmpresaModel empresa, int id)
        {
            EmpresaModel empresaPorId = await BuscarPorId(id);

            if (empresaPorId == null)
            {
                throw new Exception($"Vendedor do ID: {id} não foi encontrado no banco de dados.");
            }

            empresaPorId.Nome = empresaPorId.Nome;
            empresaPorId.ComissaoEmpresaId = empresaPorId.ComissaoEmpresaId;

            _dbContext.Empresas.Update(empresaPorId);
            await _dbContext.SaveChangesAsync();

            return empresaPorId;
        }

        public async Task<bool> Apagar(int id)
        {
            EmpresaModel empresaPorId = await BuscarPorId(id);

            if (empresaPorId == null)
            {
                throw new Exception($"Empresa do ID: {id} não foi encontrado no banco de dados.");
            }

            _dbContext.Empresas.Remove(empresaPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
