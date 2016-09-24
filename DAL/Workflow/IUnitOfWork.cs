namespace DAL.Workflow
{
	public interface IUnitOfWork
	{
		IProcessRepository ProcessRepository { get; }
	}
}
