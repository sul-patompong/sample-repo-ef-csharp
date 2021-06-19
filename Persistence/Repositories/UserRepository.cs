using System.Linq;
using sample_repo_ef_csharp.Core.Domain;
using sample_repo_ef_csharp.Core.Repositories;

namespace sample_repo_ef_csharp.Persistence.Repositories
{
    public class UserRepository : Repository<User> , IUserRepository
    {
        private readonly CoreDbContext _context;
        public UserRepository(CoreDbContext context) : base(context)
        {
            _context = context;
        }

        public User GetLastUpdatedUser()
        {
            var user = _context.Users.OrderBy(u => u.UpdatedAt).FirstOrDefault();
            return user;
        }
    }
}