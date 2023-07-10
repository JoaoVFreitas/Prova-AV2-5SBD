namespace CooperativaCredito_AGrana.Models
{
    public class ComissaoVendedorModel
    {
        public int Id { get; set; }
        public float Valor { get; set; }
        public int ParcelasPagas { get; set; }
        public int FinanciamentoId { get; set; }
        public virtual FinanciamentoModel? Financiamento { get; set; }
        public int VendedorId { get; set; }
        public virtual VendedorModel? Vendedor { get; set; }
    }
}