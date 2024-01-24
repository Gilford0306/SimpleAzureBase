using ConsoleApp3;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp3
{
    public class MyApplicationContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:pavelserver.database.windows.net,1433;Initial Catalog=test2db;Persist Security Info=False;User ID=Gilford;Password=Paul0306;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
