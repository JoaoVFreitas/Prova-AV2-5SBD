using CooperativaCredito_AGrana.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CooperativaCredito_AGrana.Data.Map
{
    public class ComissaoEmpresaMap : IEntityTypeConfiguration<ComissaoEmpresaModel>
    {
        public void Configure(EntityTypeBuilder<ComissaoEmpresaModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Valor).IsRequired();
            builder.Property(x => x.ParcelasPagas).IsRequired();
            builder.Property(x => x.FinanciamentoId).IsRequired();
            builder.Property(x => x.EmpresaId).IsRequired();

            builder.HasOne(x => x.Financiamento);
            builder.HasOne(x => x.Empresa);
        }
    }
}