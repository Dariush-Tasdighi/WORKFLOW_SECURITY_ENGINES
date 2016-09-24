using System.Linq;
using System.Data.Entity;

namespace Models.Workflow.Infrastructure
{
	public static class Utility
	{
		static Utility()
		{
		}

		public static void Seed(DatabaseContext databaseContext)
		{
			Process oProcess = null;

			oProcess = new Process();

			oProcess.Ordering = 1;
			oProcess.IsActive = true;
			oProcess.Name = "Process (1)";

			oProcess.Code =
				(int)Enums.Processes.Process01;

			databaseContext.WorkflowProcesses.Add(oProcess);

			oProcess = new Process();

			oProcess.Ordering = 2;
			oProcess.IsActive = false;
			oProcess.Name = "Process (2)";

			oProcess.Code =
				(int)Enums.Processes.Process02;

			databaseContext.WorkflowProcesses.Add(oProcess);

			// برای تست
			databaseContext.SaveChanges();
		}
	}
}
