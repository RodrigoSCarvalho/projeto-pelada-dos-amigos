using Microsoft.EntityFrameworkCore;

namespace Proj_Pelada_Dos_Amigos.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Time> Times { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<Pote> Potes { get; set; }
    }
}
