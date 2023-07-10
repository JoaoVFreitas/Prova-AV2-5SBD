using CooperativaCredito_AGrana.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CooperativaCredito_AGrana.Data.Map
{
    public class FinanciamentoMap : IEntityTypeConfiguration<FinanciamentoModel>
    {
        public void Configure(EntityTypeBuilder<FinanciamentoModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Valor).IsRequired();
            builder.Property(x => x.Juros).IsRequired();
            builder.Property(x => x.BemDuravel).IsRequired();
            builder.Property(x => x.PorcentagemSalario).IsRequired();
            builder.Property(x => x.AssociadoId).IsRequired();
            builder.Property(x => x.VendedorId).IsRequired();

            builder.HasOne(x => x.Associado);
            builder.HasOne(x => x.Vendedor);
        }
    }
}