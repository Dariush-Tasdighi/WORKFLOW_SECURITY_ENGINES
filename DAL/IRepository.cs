namespace DAL
{
	public interface IRepository<T> where T : Models.Infrastructure.BaseEntity
	{
		void Insert(T entity);

		void Update(T entity);

		void Delete(T entity);

		bool DeleteById(System.Guid id);

		T GetById(System.Guid id);

		System.Linq.IQueryable<T> Get();

		System.Linq.IQueryable<T>
			Get(System.Linq.Expressions.Expression<System.Func<T, bool>> predicate);

		System.Collections.Generic.IEnumerable<T>
			GetWithRawSql(string query, params object[] parameters);
	}
}
