using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ApiChamados.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            optionsBuilder.UseSqlite("Data Source=chamados.db");
            //optionsBuilder.UseSqlServer(
            //    "Server=localhost;Database=ChamadosDB;Trusted_Connection=True;TrustServerCertificate=True"
            //);

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
