using CooperativaCredito_AGrana.Models;

namespace CooperativaCredito_AGrana.Repositorios.Interfaces
{
    public interface IVendedorRepositorio
    {
        Task<List<VendedorModel>> BuscarTodosVendedores();
        Task<VendedorModel> BuscarPorId(int id);
        Task<VendedorModel> Adicionar(VendedorModel vendedor);
        Task<VendedorModel> Atualizar(VendedorModel vendedor, int id);
        Task<bool> Apagar(int id);
    }
}
