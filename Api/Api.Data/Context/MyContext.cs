using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<CadastroClienteEntity> CadastroClientes { get; set; }
        public DbSet<CadastroFuncionarioEntity> CadastroFuncionarios { get; set; }
        public DbSet<CadastroVeiculoEntity> CadastroVeiculos { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
