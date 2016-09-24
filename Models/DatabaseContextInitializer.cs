namespace Models
{
	internal static class DatabaseContextInitializer
	{
		static DatabaseContextInitializer()
		{
		}

		internal static void Seed(DatabaseContext databaseContext)
		{
			Workflow.Infrastructure.Utility.Seed(databaseContext);
		}
	}
}
