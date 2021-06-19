using sample_repo_ef_csharp.Core.Domain;

namespace sample_repo_ef_csharp.Core.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User GetLastUpdatedUser();
    }
}