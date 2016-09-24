namespace Models
{
	internal class DatabaseContextInitializerBeforeTheFirstRelease :
		System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>
	{
		public DatabaseContextInitializerBeforeTheFirstRelease() : base()
		{
		}

		protected override void Seed(DatabaseContext databaseContext)
		{
			base.Seed(databaseContext);

			try
			{
				DatabaseContextInitializer.Seed(databaseContext);
			}
			catch
			// TODO
			//catch (System.Exception ex)
			{
				//Dtx.LogHandler.Report(GetType(), null, ex);
			}
		}
	}
}
