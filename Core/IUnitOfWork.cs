using sample_repo_ef_csharp.Core.Repositories;
using sample_repo_ef_csharp.Persistence.Repositories;

namespace sample_repo_ef_csharp.Core
{
    public interface IUnitOfWork
    {
        ICarRepository Cars { get; }
        IUserRepository Users { get; }

        int Complete();
        void Dispose();
    }
}