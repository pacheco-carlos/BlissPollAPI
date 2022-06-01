using BlissPollAPI.Model;

namespace BlissPollAPI.Interfaces
{
	public interface IPollRepository : IRepository<Poll>
	{
		Task<List<Poll>> GetPolls();
	}
}
