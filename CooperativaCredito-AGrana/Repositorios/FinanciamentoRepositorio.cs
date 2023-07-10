using CooperativaCredito_AGrana.Data;
using CooperativaCredito_AGrana.Models;
using CooperativaCredito_AGrana.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CooperativaCredito_AGrana.Repositorios
{
    public class FinanciamentoRepositorio : IFinanciamentoRepositorio
    {
        private readonly AGranaDBContext _dbContext;
        public FinanciamentoRepositorio(AGranaDBContext aGranaDBContext)
        {
            _dbContext = aGranaDBContext;
        }
        public async Task<FinanciamentoModel> BuscarPorId(int id)
        {
            return await _dbContext.Financiamentos.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<FinanciamentoModel>> BuscarTodosFinanciamentos()
        {
            return await _dbContext.Financiamentos.ToListAsync();
        }
        public async Task<FinanciamentoModel> Adicionar(FinanciamentoModel financiamento)
        {
            await _dbContext.Financiamentos.AddAsync(financiamento);
            await _dbContext.SaveChangesAsync();

            return financiamento;
        }

        public async Task<FinanciamentoModel> Atualizar(FinanciamentoModel financiamento, int id)
        {
            FinanciamentoModel financiamentoPorId = await BuscarPorId(id);

            if (financiamentoPorId == null)
            {
                throw new Exception($"Financiamento do ID: {id} não foi encontrado no banco de dados.");
            }

            financiamentoPorId.Valor = financiamento.Valor;
            financiamentoPorId.Juros = financiamento.Juros;
            financiamentoPorId.BemDuravel = financiamento.BemDuravel;
            financiamentoPorId.PorcentagemSalario = financiamento.PorcentagemSalario;
            financiamentoPorId.AssociadoId = financiamento.AssociadoId;
            financiamentoPorId.VendedorId = financiamento.VendedorId;

            _dbContext.Financiamentos.Update(financiamentoPorId);
            await _dbContext.SaveChangesAsync();

            return financiamentoPorId;
        }

        public async Task<bool> Apagar(int id)
        {
            FinanciamentoModel financiamentoPorId = await BuscarPorId(id);

            if (financiamentoPorId == null)
            {
                throw new Exception($"Financiamento do ID: {id} não foi encontrado no banco de dados.");
            }

            _dbContext.Financiamentos.Remove(financiamentoPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
