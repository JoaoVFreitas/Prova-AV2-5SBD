using CooperativaCredito_AGrana.Models;

namespace CooperativaCredito_AGrana.Repositorios.Interfaces
{
    public interface IEmpresaRepositorio
    {
        Task<List<EmpresaModel>> BuscarTodasEmpresas();
        Task<EmpresaModel> BuscarPorId(int id);
        Task<EmpresaModel> Adicionar(EmpresaModel empresa);
        Task<EmpresaModel> Atualizar(EmpresaModel empresa, int id);
        Task<bool> Apagar(int id);
    }
}
