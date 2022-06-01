namespace BlissPollAPI.Interfaces
{
	public interface IRepository<T> where T : class
	{
		Task<T> Get(int id);
		Task<List<T>> GetAll();
		Task Create(T entity);
		Task Update(T entity);
		Task Delete(T entity);
	}
}
