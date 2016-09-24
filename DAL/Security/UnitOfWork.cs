namespace DAL.Security
{
	public class UnitOfWork : object, IUnitOfWork
	{
		public UnitOfWork(Models.DatabaseContext databaseContext)
			: base()
		{
			if (databaseContext == null)
			{
				throw (new System.ArgumentNullException("databaseContext"));
			}

			DatabaseContext = databaseContext;
		}

		protected Models.DatabaseContext DatabaseContext { get; set; }

		// **************************************************
		//private IRepository _Repository;

		//public IRepository Repository
		//{
		//	get
		//	{
		//		if (_Repository == null)
		//		{
		//			_Repository =
		//				new Repository(DatabaseContext);
		//		}

		//		return (_Repository);
		//	}
		//}
		// **************************************************

		// **************************************************
		private IRolesRepository _rolesRepository;

		public IRolesRepository RolesRepository
		{
			get
			{
				if (_rolesRepository == null)
				{
					_rolesRepository =
						new RolesRepository(DatabaseContext);
				}

				return (_rolesRepository);
			}
		}
		// **************************************************
	}
}
