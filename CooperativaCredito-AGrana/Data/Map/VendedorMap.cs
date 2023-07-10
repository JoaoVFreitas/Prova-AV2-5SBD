using CooperativaCredito_AGrana.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CooperativaCredito_AGrana.Data.Map
{
    public class VendedorMap : IEntityTypeConfiguration<VendedorModel>
    {
        public void Configure(EntityTypeBuilder<VendedorModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.ComissaoVendedorId);

            builder.HasOne(x => x.ComissaoVendedor);
        }
    }
}