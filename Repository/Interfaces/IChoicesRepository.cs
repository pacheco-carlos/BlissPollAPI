using BlissPollAPI.Entities.Models;

namespace BlissPollAPI.Repository.Interfaces
{
	public interface IChoicesRepository : IRepository<Choices>
	{
		Task<List<Choices>> GetAllByPoll(int pollId);
	}
}
