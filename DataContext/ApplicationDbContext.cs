using Microsoft.EntityFrameworkCore;
using webApi.Models;

namespace webApi.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ContaModel> Contas { get; set; }
        public DbSet<BancoModel> Bancos { get; set; }
        public DbSet<FormaPagamentoModel> FormasPagamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContaModel>()
                .HasOne(p => p.Bancos)
                .WithMany(b => b.Contas)
                .HasForeignKey(p => p.Id_banco);

            modelBuilder.Entity<ContaModel>()
                .HasOne(p => p.FormaPagamento)
                .WithMany(b => b.Contas)
                .HasForeignKey(p => p.Id_formapagamento);
        }

    }
}