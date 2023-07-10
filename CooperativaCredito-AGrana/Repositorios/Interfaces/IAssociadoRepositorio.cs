using CooperativaCredito_AGrana.Models;

namespace CooperativaCredito_AGrana.Repositorios.Interfaces
{
    public interface IAssociadoRepositorio
    {
        Task<List<AssociadoModel>> BuscarTodosAssociados();
        Task<AssociadoModel> BuscarPorId(int id);
        Task<AssociadoModel> Adicionar(AssociadoModel associado);
        Task<AssociadoModel> Atualizar(AssociadoModel associado, int id);
        Task<bool> Apagar(int id);
    }
}
