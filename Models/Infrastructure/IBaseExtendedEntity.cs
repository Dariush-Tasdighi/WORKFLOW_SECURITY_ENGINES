namespace Models.Infrastructure
{
	public interface IBaseExtendedEntity
	{
		bool IsActive { get; }

		bool IsSystem { get; }

		bool IsDeleted { get; }

		bool IsVerified { get; }
	}
}
