namespace sample_repo_ef_csharp.Persistence.Repositories
{
    public class UnitOfWork
    {
        private readonly CoreDbContext _context;

        public UnitOfWork(CoreDbContext context)
        {
            _context = context;
            Cars = new CarRepository(context);
            Users = new UserRepository(context);
        }

        public CarRepository Cars { get; private set; }
        public UserRepository Users { get; private set; }

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