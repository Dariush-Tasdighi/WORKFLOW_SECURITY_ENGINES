namespace Models
{
	public class DatabaseContext : System.Data.Entity.DbContext
	{
		static DatabaseContext()
		{
			System.Data.Entity.Database.SetInitializer
				(new DatabaseContextInitializerBeforeTheFirstRelease());

			//System.Data.Entity.Database.SetInitializer
			//	(new System.Data.Entity.MigrateDatabaseToLatestVersion
			//		<DatabaseContext, Migrations.Configuration>());
		}

		public DatabaseContext()
		{
		}

		// **********
		// **********
		// **********
		public System.Data.Entity.DbSet<User> Users { get; set; }
		// **********
		// **********
		// **********

		// **********
		// **********
		// **********
		public System.Data.Entity.DbSet<Security.Role> SecurityRoles { get; set; }

		public System.Data.Entity.DbSet<Security.Group> SecurityGroups { get; set; }
		// **********
		// **********
		// **********

		// **********
		// **********
		// **********

		public System.Data.Entity.DbSet<Workflow.Process> WorkflowProcesses { get; set; }

		public System.Data.Entity.DbSet<Workflow.StateType> WorkflowStateTypes { get; set; }

		public System.Data.Entity.DbSet<Workflow.ActionType> WorkflowActionTypes { get; set; }

		public System.Data.Entity.DbSet<Workflow.ActivityType> WorkflowActivityTypes { get; set; }
		// **********
		// **********
		// **********

		protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Configurations.Add(new User.Configuration());

			modelBuilder.Configurations.Add(new Security.Role.Configuration());
			modelBuilder.Configurations.Add(new Security.Group.Configuration());

			modelBuilder.Configurations.Add(new Workflow.Process.Configuration());
			modelBuilder.Configurations.Add(new Workflow.StateType.Configuration());
			modelBuilder.Configurations.Add(new Workflow.ActionType.Configuration());
			modelBuilder.Configurations.Add(new Workflow.ActivityType.Configuration());
		}
	}
}
