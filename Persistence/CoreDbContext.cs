using System.IO;
using Microsoft.EntityFrameworkCore;
using sample_repo_ef_csharp.Core.Domain;

namespace sample_repo_ef_csharp.Persistence
{
    public class CoreDbContext : DbContext
    {
        private DbSet<User> Users { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlite(@"Data Source=" + Path.Combine("Persistence","Sqlite","CoreDb.db")));
        }
    }
}