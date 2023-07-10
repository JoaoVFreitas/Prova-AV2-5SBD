using CooperativaCredito_AGrana.Data.Map;
using CooperativaCredito_AGrana.Models;
using Microsoft.EntityFrameworkCore;

namespace CooperativaCredito_AGrana.Data
{
    public class AGranaDBContext : DbContext
    {
        public AGranaDBContext(DbContextOptions<AGranaDBContext> options)
            : base(options)
        {        
        }

        public DbSet<AssociadoModel> Associados { get; set; }
        public DbSet<ComissaoEmpresaModel> ComissoesEmpresa { get; set; }
        public DbSet<ComissaoVendedorModel> ComissoesVendedor { get; set; }
        public DbSet<EmpresaModel> Empresas { get; set; }
        public DbSet<FinanciamentoModel> Financiamentos { get; set; }
        public DbSet<VendedorModel> Vendedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssociadoModel>()
                .HasOne(a => a.Financiamento)
                .WithOne()
                .HasForeignKey<AssociadoModel>(a => a.FinanciamentoId);

            modelBuilder.Entity<FinanciamentoModel>()
                .HasOne(f => f.Associado)
                .WithOne()
                .HasForeignKey<FinanciamentoModel>(f => f.AssociadoId);

            modelBuilder.Entity<ComissaoEmpresaModel>()
                .HasOne(a => a.Empresa)
                .WithOne()
                .HasForeignKey<ComissaoEmpresaModel>(a => a.EmpresaId);

            modelBuilder.Entity<EmpresaModel>()
                .HasOne(f => f.ComissaoEmpresa)
                .WithOne()
                .HasForeignKey<EmpresaModel>(f => f.ComissaoEmpresaId);

            modelBuilder.Entity<ComissaoVendedorModel>()
                .HasOne(a => a.Vendedor)
                .WithOne()
                .HasForeignKey<ComissaoVendedorModel>(a => a.VendedorId);

            modelBuilder.Entity<VendedorModel>()
                .HasOne(f => f.ComissaoVendedor)
                .WithOne()
                .HasForeignKey<VendedorModel>(f => f.ComissaoVendedorId);



            modelBuilder.ApplyConfiguration(new AssociadoMap());
            modelBuilder.ApplyConfiguration(new ComissaoEmpresaMap());
            modelBuilder.ApplyConfiguration(new ComissaoVendedorMap());
            modelBuilder.ApplyConfiguration(new EmpresaMap());
            modelBuilder.ApplyConfiguration(new FinanciamentoMap());
            modelBuilder.ApplyConfiguration(new VendedorMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}