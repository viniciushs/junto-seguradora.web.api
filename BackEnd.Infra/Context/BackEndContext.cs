using BackEnd.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Infra.Context
{
    public class BackEndContext : DbContext
    {
        //Construtor utilizado somente para o recurso do Code First (Fluent API)
        //public BackEndContext() { }

        public BackEndContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<Cargo> Cargo { get; set; }
        public DbSet<FormaPagto> FormaPagto { get; set; }

        public DbSet<Situacao> Situacao { get; set; }

        public DbSet<Franqueado> Franqueado { get; set; }

        public DbSet<Funcionario> Funcionario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
