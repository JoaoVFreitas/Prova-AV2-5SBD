using CooperativaCredito_AGrana.Data;
using CooperativaCredito_AGrana.Models;
using CooperativaCredito_AGrana.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CooperativaCredito_AGrana.Repositorios
{
    public class VendedorRepositorio : IVendedorRepositorio
    {
        private readonly AGranaDBContext _dbContext;
        public VendedorRepositorio(AGranaDBContext aGranaDBContext)
        {
            _dbContext = aGranaDBContext;
        }

        public async Task<VendedorModel> BuscarPorId(int id)
        {
            return await _dbContext.Vendedores.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<VendedorModel>> BuscarTodosVendedores()
        {
            return await _dbContext.Vendedores.ToListAsync();
        }

        public async Task<VendedorModel> Adicionar(VendedorModel vendedor)
        {
            await _dbContext.Vendedores.AddAsync(vendedor);
            await _dbContext.SaveChangesAsync();

            return vendedor;
        }

        public async Task<VendedorModel> Atualizar(VendedorModel vendedor, int id)
        {
            VendedorModel vendedorPorId = await BuscarPorId(id);
            
            if(vendedorPorId == null)
            {
                throw new Exception($"Vendedor do ID: {id} não foi encontrado no banco de dados.");
            }

            vendedorPorId.Nome = vendedor.Nome;
            vendedorPorId.Email = vendedor.Email;
            vendedorPorId.ComissaoVendedorId = vendedor.ComissaoVendedorId;

            _dbContext.Vendedores.Update(vendedorPorId);
            await _dbContext.SaveChangesAsync();

            return vendedorPorId;
        }

        public async Task<bool> Apagar(int id)
        {
            VendedorModel vendedorPorId = await BuscarPorId(id);

            if (vendedorPorId == null)
            {
                throw new Exception($"Vendedor do ID: {id} não foi encontrado no banco de dados.");
            }

            _dbContext.Vendedores.Remove(vendedorPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
