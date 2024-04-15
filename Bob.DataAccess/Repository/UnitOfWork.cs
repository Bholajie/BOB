using Bob.DataAccess.Repository.IRepository;
using Bob.Migrations.Data;

namespace Bob.DataAccess.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
		public IUserRepository User { get; private set; }

		private ApplicationDbContext _db;

		public UnitOfWork(ApplicationDbContext db)
		{
			_db = db;
			User = new UserRepository(_db);

		}

	}
}
