using CooperativaCredito_AGrana.Models;

namespace CooperativaCredito_AGrana.Repositorios.Interfaces
{
    public interface IComissaoEmpresaRepositorio
    {
        Task<List<ComissaoEmpresaModel>> BuscarTodasComissoesEmpresa();
        Task<ComissaoEmpresaModel> BuscarPorId(int id);
        Task<ComissaoEmpresaModel> Adicionar(ComissaoEmpresaModel comissaoEmpresa);
        Task<ComissaoEmpresaModel> Atualizar(ComissaoEmpresaModel comissaoEmpresa, int id);
        Task<bool> Apagar(int id);
    }
}
