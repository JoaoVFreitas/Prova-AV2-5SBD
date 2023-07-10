namespace CooperativaCredito_AGrana.Models
{
    public class AssociadoModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public float Salario { get; set; }
        public float LimiteEndividamentoMensal { get; set; }
        public bool? NomeLimpo { get; set; }
        public int? FinanciamentoId { get; set; }
        public virtual FinanciamentoModel? Financiamento { get; set; }
        public int EmpresaId { get; set; }
        public virtual EmpresaModel? Empresa { get; set; }
    }
}