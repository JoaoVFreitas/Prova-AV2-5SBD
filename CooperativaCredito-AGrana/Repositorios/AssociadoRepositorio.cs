using CooperativaCredito_AGrana.Data;
using CooperativaCredito_AGrana.Models;
using CooperativaCredito_AGrana.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CooperativaCredito_AGrana.Repositorios
{
    public class AssociadoRepositorio : IAssociadoRepositorio
    {
        private readonly AGranaDBContext _dbContext;
        public AssociadoRepositorio(AGranaDBContext aGranaDBContext)
        {
            _dbContext = aGranaDBContext;
        }
        public async Task<AssociadoModel> BuscarPorId(int id)
        {
            return await _dbContext.Associados.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<AssociadoModel>> BuscarTodosAssociados()
        {
            return await _dbContext.Associados.ToListAsync();
        }
        public async Task<AssociadoModel> Adicionar(AssociadoModel associado)
        {
            await _dbContext.Associados.AddAsync(associado);
            await _dbContext.SaveChangesAsync();

            return associado;
        }

        public async Task<AssociadoModel> Atualizar(AssociadoModel associado, int id)
        {
            AssociadoModel associadoPorId = await BuscarPorId(id);

            if (associadoPorId == null)
            {
                throw new Exception($"Vendedor do ID: {id} não foi encontrado no banco de dados.");
            }

            associadoPorId.Nome = associadoPorId.Nome;
            associadoPorId.Salario = associadoPorId.Salario;
            associadoPorId.LimiteEndividamentoMensal = associadoPorId.LimiteEndividamentoMensal;
            associadoPorId.NomeLimpo = associadoPorId.NomeLimpo;
            associadoPorId.FinanciamentoId = associadoPorId.FinanciamentoId;
            associadoPorId.EmpresaId = associadoPorId.EmpresaId;


            _dbContext.Associados.Update(associadoPorId);
            await _dbContext.SaveChangesAsync();

            return associadoPorId;
        }

        public Task<bool> Apagar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
