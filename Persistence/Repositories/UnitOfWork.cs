using Microsoft.EntityFrameworkCore;
using sample_repo_ef_csharp.Core;
using sample_repo_ef_csharp.Core.Repositories;

namespace sample_repo_ef_csharp.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CoreDbContext _context;

        public UnitOfWork(CoreDbContext context)
        {
            _context = context;
            Cars = new CarRepository(context);
            Users = new UserRepository(context);
        }

        public ICarRepository Cars { get; private set; }
        public IUserRepository Users { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}