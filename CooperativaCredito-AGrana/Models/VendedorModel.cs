namespace CooperativaCredito_AGrana.Models
{
    public class VendedorModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public int? ComissaoVendedorId { get; set; }
        public virtual ComissaoVendedorModel? ComissaoVendedor { get; set; }
    }
}