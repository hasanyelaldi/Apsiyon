using Apsiyon.App.Models;
using Microsoft.EntityFrameworkCore;

namespace Apsiyon.App
{
    public class ApsiyonContext : DbContext
    {
        public DbSet<ErrorLog> Logs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=ApsiyonLog;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
