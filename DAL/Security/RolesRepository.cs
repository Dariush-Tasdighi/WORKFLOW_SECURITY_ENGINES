using System.Linq;

namespace DAL.Security
{
	public class RolesRepository : Repository<Models.Security.Role>, IRolesRepository
	{
		public RolesRepository(Models.DatabaseContext databaseContext)
			: base(databaseContext)
		{
		}
	}
}
