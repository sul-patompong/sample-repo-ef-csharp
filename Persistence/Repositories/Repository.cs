using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using sample_repo_ef_csharp.Core.Repositories;

namespace sample_repo_ef_csharp.Persistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;

        protected Repository(DbContext context)
        {
            _context = context;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetFirst()
        {
            return _context.Set<TEntity>().FirstOrDefault();
        }
    }
}