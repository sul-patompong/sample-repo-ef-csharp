using Microsoft.EntityFrameworkCore;
using sample_repo_ef_csharp.Core.Domain;

namespace sample_repo_ef_csharp.Persistence.Repositories
{
    public class CarRepository : Repository<Car>
    {
        public CarRepository(DbContext context) : base(context)
        {
        }
    }
}