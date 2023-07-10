using CooperativaCredito_AGrana.Data;
using CooperativaCredito_AGrana.Models;
using CooperativaCredito_AGrana.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CooperativaCredito_AGrana.Repositorios
{
    public class ComissaoVendedorRepositorio : IComissaoVendedorRepositorio
    {
        private readonly AGranaDBContext _dbContext;
        public ComissaoVendedorRepositorio(AGranaDBContext aGranaDBContext)
        {
            _dbContext = aGranaDBContext;
        }
        public async Task<ComissaoVendedorModel> BuscarPorId(int id)
        {
            return await _dbContext.ComissoesVendedor.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<ComissaoVendedorModel>> BuscarTodasComissoesVendedor()
        {
            return await _dbContext.ComissoesVendedor.ToListAsync();
        }
        public async Task<ComissaoVendedorModel> Adicionar(ComissaoVendedorModel comissaoVendedor)
        {
            await _dbContext.ComissoesVendedor.AddAsync(comissaoVendedor);
            await _dbContext.SaveChangesAsync();

            return comissaoVendedor;
        }

        public async Task<ComissaoVendedorModel> Atualizar(ComissaoVendedorModel comissaoVendedor, int id)
        {
            ComissaoVendedorModel comissaoVendedorPorId = await BuscarPorId(id);

            if (comissaoVendedorPorId == null)
            {
                throw new Exception($"Comissão do Vendedor do ID: {id} não foi encontrado no banco de dados.");
            }

            comissaoVendedorPorId.Valor = comissaoVendedorPorId.Valor;
            comissaoVendedorPorId.ParcelasPagas = comissaoVendedorPorId.ParcelasPagas;
            comissaoVendedorPorId.FinanciamentoId = comissaoVendedorPorId.FinanciamentoId;
            comissaoVendedorPorId.VendedorId = comissaoVendedorPorId.VendedorId;


            _dbContext.ComissoesVendedor.Update(comissaoVendedorPorId);
            await _dbContext.SaveChangesAsync();

            return comissaoVendedorPorId;
        }

        public Task<bool> Apagar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
