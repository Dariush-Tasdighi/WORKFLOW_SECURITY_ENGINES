namespace DAL.Workflow
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
		private IProcessRepository _processRepository;

		public IProcessRepository ProcessRepository
		{
			get
			{
				if (_processRepository == null)
				{
					_processRepository =
						new ProcessRepository(DatabaseContext);
				}

				return (_processRepository);
			}
		}
		// **************************************************
	}
}
