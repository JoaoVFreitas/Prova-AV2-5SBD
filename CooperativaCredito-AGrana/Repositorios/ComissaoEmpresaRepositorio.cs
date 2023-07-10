using CooperativaCredito_AGrana.Data;
using CooperativaCredito_AGrana.Models;
using CooperativaCredito_AGrana.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CooperativaCredito_AGrana.Repositorios
{
    public class ComissaoEmpresaRepositorio : IComissaoEmpresaRepositorio
    {
        private readonly AGranaDBContext _dbContext;
        public ComissaoEmpresaRepositorio(AGranaDBContext aGranaDBContext)
        {
            _dbContext = aGranaDBContext;
        }
        public async Task<ComissaoEmpresaModel> BuscarPorId(int id)
        {
            return await _dbContext.ComissoesEmpresa.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<ComissaoEmpresaModel>> BuscarTodasComissoesEmpresa()
        {
            return await _dbContext.ComissoesEmpresa.ToListAsync();
        }
        public async Task<ComissaoEmpresaModel> Adicionar(ComissaoEmpresaModel comissaoEmpresa)
        {
            await _dbContext.ComissoesEmpresa.AddAsync(comissaoEmpresa);
            await _dbContext.SaveChangesAsync();

            return comissaoEmpresa;
        }

        public async Task<ComissaoEmpresaModel> Atualizar(ComissaoEmpresaModel comissaoEmpresa, int id)
        {
            ComissaoEmpresaModel comissaoEmpresaPorId = await BuscarPorId(id);

            if (comissaoEmpresaPorId == null)
            {
                throw new Exception($"Comissão da Empresa do ID: {id} não foi encontrado no banco de dados.");
            }

            comissaoEmpresaPorId.Valor = comissaoEmpresaPorId.Valor;
            comissaoEmpresaPorId.ParcelasPagas = comissaoEmpresaPorId.ParcelasPagas;
            comissaoEmpresaPorId.FinanciamentoId = comissaoEmpresaPorId.FinanciamentoId;
            comissaoEmpresaPorId.EmpresaId = comissaoEmpresaPorId.EmpresaId;


            _dbContext.ComissoesEmpresa.Update(comissaoEmpresaPorId);
            await _dbContext.SaveChangesAsync();

            return comissaoEmpresaPorId;
        }

        public Task<bool> Apagar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
