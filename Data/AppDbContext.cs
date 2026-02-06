using Microsoft.EntityFrameworkCore;
using ApiChamados.Models;

namespace ApiChamados.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Chamado> Chamados => Set<Chamado>();
    }
}
