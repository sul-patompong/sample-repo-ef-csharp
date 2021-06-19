using System.Collections.Generic;

namespace sample_repo_ef_csharp.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
         IEnumerable<TEntity> GetAll();
    }
}