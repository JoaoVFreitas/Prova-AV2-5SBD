namespace CooperativaCredito_AGrana.Models
{
    public class ComissaoEmpresaModel
    {
        public int Id { get; set; }
        public float Valor { get; set; }
        public int ParcelasPagas { get; set; }
        public int FinanciamentoId { get; set; }
        public virtual FinanciamentoModel? Financiamento { get; set; }
        public int EmpresaId { get; set; }
        public virtual EmpresaModel? Empresa { get; set; }
    }
}
