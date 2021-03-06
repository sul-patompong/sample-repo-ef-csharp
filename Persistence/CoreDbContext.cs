using System.IO;
using Microsoft.EntityFrameworkCore;
using sample_repo_ef_csharp.Core.Domain;

namespace sample_repo_ef_csharp.Persistence
{
    public class CoreDbContext : DbContext
    {
        public CoreDbContext(DbContextOptions<CoreDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}