namespace DAL.Security
{
	public interface IUnitOfWork
	{
		IRolesRepository RolesRepository { get; }
	}
}
