using System.Linq;

namespace DAL
{
	public class UserRepository : Repository<Models.User>, IUserRepository
	{
		public UserRepository(Models.DatabaseContext databaseContext) : base(databaseContext)
		{
		}
	}
}
