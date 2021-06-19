using Microsoft.EntityFrameworkCore;
using sample_repo_ef_csharp.Core.Domain;
using sample_repo_ef_csharp.Core.Repositories;

namespace sample_repo_ef_csharp.Persistence.Repositories
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        public CarRepository(CoreDbContext context) : base(context)
        {
        }
    }
}