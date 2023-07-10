using CooperativaCredito_AGrana.Models;

namespace CooperativaCredito_AGrana.Repositorios.Interfaces
{
    public interface IComissaoVendedorRepositorio
    {
        Task<List<ComissaoVendedorModel>> BuscarTodasComissoesVendedor();
        Task<ComissaoVendedorModel> BuscarPorId(int id);
        Task<ComissaoVendedorModel> Adicionar(ComissaoVendedorModel comissaoVendedor);
        Task<ComissaoVendedorModel> Atualizar(ComissaoVendedorModel comissaoVendedor, int id);
        Task<bool> Apagar(int id);
    }
}
