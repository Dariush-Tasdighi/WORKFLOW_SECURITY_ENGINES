using System.Linq;

namespace DAL.Workflow
{
	public class ProcessRepository : Repository<Models.Workflow.Process>, IProcessRepository
	{
		public ProcessRepository(Models.DatabaseContext databaseContext)
			: base(databaseContext)
		{
		}
	}
}
