namespace DAL
{
	public class UnitOfWork : object, IUnitOfWork
	{
		public UnitOfWork()
		{
			IsDisposed = false;
		}

		protected bool IsDisposed { get; set; }

		// **************************************************
		private Models.DatabaseContext _databaseContext;

		protected virtual Models.DatabaseContext DatabaseContext
		{
			get
			{
				if (_databaseContext == null)
				{
					_databaseContext =
						new Models.DatabaseContext();
				}

				return (_databaseContext);
			}
		}
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		private Workflow.IUnitOfWork _workflowUnitOfWork;

		public Workflow.IUnitOfWork WorkflowUnitOfWork
		{
			get
			{
				if (_workflowUnitOfWork == null)
				{
					_workflowUnitOfWork =
						new Workflow.UnitOfWork(DatabaseContext);
				}

				return (_workflowUnitOfWork);
			}
		}
		// **************************************************
		// **************************************************
		// **************************************************

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
		// **************************************************
		// **************************************************
		private IUserRepository _userRepository;

		public IUserRepository UserRepository
		{
			get
			{
				if (_userRepository == null)
				{
					_userRepository =
						new UserRepository(DatabaseContext);
				}

				return (_userRepository);
			}
		}
		// **************************************************
		// **************************************************
		// **************************************************

		public void Save()
		{
			try
			{
				DatabaseContext.SaveChanges();
			}
			catch
			// TODO
			//catch (System.Exception ex)
			{
				//Dtx.LogHandler.Report(GetType(), null, ex);

				throw;
			}
		}

		//public virtual int ExecuteSqlCommand(string commandText)
		//{
		//	int intResult = -1;

		//	using (System.Transactions.TransactionScope oTransactionScope =
		//		new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Suppress))
		//	{
		//		intResult = DatabaseContext.Database.ExecuteSqlCommand
		//			(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, commandText);
		//	}

		//	return (intResult);
		//}

		//public virtual int BackupDatabase
		//	(ViewModels.Areas.Administrator.Programmer.BackupDatabaseViewModel viewModel, string pathName)
		//{
		//	string strDatabaseName =
		//		DatabaseContext.Database.Connection.Database;

		//	string strCommandText =
		//		string.Format("BACKUP DATABASE [{0}] TO  DISK = N'{1}' WITH", strDatabaseName, pathName);

		//	if (viewModel.INIT)
		//	{
		//		strCommandText += " " + "INIT";
		//	}
		//	else
		//	{
		//		strCommandText += " " + "NOINIT";
		//	}

		//	if (viewModel.SKIP)
		//	{
		//		strCommandText += ", " + "SKIP";
		//	}
		//	else
		//	{
		//		strCommandText += ", " + "NOSKIP";
		//	}

		//	if (viewModel.FORMAT)
		//	{
		//		strCommandText += ", " + "FORMAT";
		//	}
		//	else
		//	{
		//		strCommandText += ", " + "NOFORMAT";
		//	}

		//	if (viewModel.CHECKSUM)
		//	{
		//		strCommandText += ", " + "CHECKSUM";
		//	}
		//	else
		//	{
		//		strCommandText += ", " + "NO-CHECKSUM";
		//	}

		//	if (viewModel.CONTINUE_AFTER_ERROR)
		//	{
		//		strCommandText += ", " + "CONTINUE_AFTER_ERROR";
		//	}
		//	else
		//	{
		//		strCommandText += ", " + "STOP_ON_ERROR";
		//	}

		//	if (string.IsNullOrWhiteSpace(viewModel.NAME) == false)
		//	{
		//		strCommandText += ", NAME = N'" + viewModel.NAME + "'";
		//	}

		//	if (string.IsNullOrWhiteSpace(viewModel.MEDIANAME) == false)
		//	{
		//		strCommandText += ", MEDIANAME = N'" + viewModel.MEDIANAME + "'";
		//	}

		//	if (string.IsNullOrWhiteSpace(viewModel.MEDIADESCRIPTION) == false)
		//	{
		//		strCommandText += ", MEDIADESCRIPTION = N'" + viewModel.MEDIADESCRIPTION + "'";
		//	}

		//	int intResult = ExecuteSqlCommand(strCommandText);

		//	return (intResult);
		//}

		protected virtual void Dispose(bool disposing)
		{
			if (IsDisposed == false)
			{
				if (disposing)
				{
					_databaseContext.Dispose();
				}
			}
			IsDisposed = true;
		}

		public void Dispose()
		{
			Dispose(true);
			System.GC.SuppressFinalize(this);
		}
	}
}
