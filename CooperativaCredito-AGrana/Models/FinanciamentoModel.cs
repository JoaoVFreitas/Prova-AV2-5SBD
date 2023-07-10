namespace CooperativaCredito_AGrana.Models
{
    public class FinanciamentoModel
    {
        public int Id { get; set; }
        public float Valor { get; set; }
        public float Juros { get; set; }
        public string? BemDuravel { get; set; }
        public float PorcentagemSalario { get; set; }
        public int AssociadoId { get; set; }
        public virtual AssociadoModel? Associado { get; set; }
        public int VendedorId { get; set; }
        public virtual VendedorModel? Vendedor { get; set; }

    }
}