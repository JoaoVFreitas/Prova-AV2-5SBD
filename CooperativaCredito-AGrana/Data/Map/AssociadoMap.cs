using CooperativaCredito_AGrana.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CooperativaCredito_AGrana.Data.Map
{
    public class AssociadoMap : IEntityTypeConfiguration<AssociadoModel>
    {
        public void Configure(EntityTypeBuilder<AssociadoModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Salario).IsRequired();
            builder.Property(x => x.LimiteEndividamentoMensal).IsRequired();
            builder.Property(x => x.NomeLimpo).IsRequired();
            builder.Property(x => x.FinanciamentoId);
            builder.Property(x => x.EmpresaId);

            builder.HasOne(x => x.Financiamento);
            builder.HasOne(x => x.Empresa);
        }
    }
}