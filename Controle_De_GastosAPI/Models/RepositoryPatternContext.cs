using Microsoft.EntityFrameworkCore;

namespace Controle_De_GastosAPI.Models
{
    public class RepositoryPatternContext : DbContext
    {
        public RepositoryPatternContext(DbContextOptions<RepositoryPatternContext> options) : base(options)
        {
        }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Banco> Banco { get; set; }
        public DbSet<Dinheiro_Gasto> Saque { get; set; }
        public DbSet<Dinheiro_Guadado> Deposito { get; set; }
    }
}
