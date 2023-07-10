using CooperativaCredito_AGrana.Models;

namespace CooperativaCredito_AGrana.Repositorios.Interfaces
{
    public interface IFinanciamentoRepositorio
    {
        Task<List<FinanciamentoModel>> BuscarTodosFinanciamentos();
        Task<FinanciamentoModel> BuscarPorId(int id);
        Task<FinanciamentoModel> Adicionar(FinanciamentoModel financiamento);
        Task<FinanciamentoModel> Atualizar(FinanciamentoModel financiamento, int id);
        Task<bool> Apagar(int id);
    }
}
