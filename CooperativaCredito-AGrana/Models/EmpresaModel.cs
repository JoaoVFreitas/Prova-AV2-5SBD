namespace CooperativaCredito_AGrana.Models
{
    public class EmpresaModel
    {
        public int Id { get; set; }
        public string? Nome { get; set;}
        public int? ComissaoEmpresaId { get; set; }
        public virtual ComissaoEmpresaModel? ComissaoEmpresa { get; set; }
    }
}