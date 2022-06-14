using BlissPollAPI.Entities.Models;

namespace BlissPollAPI.Repository.Interfaces
{
	public interface IPollRepository : IRepository<Poll>
	{
		Task<List<Poll>> GetPolls(QuestionParameters questionParameters);
	}
}
