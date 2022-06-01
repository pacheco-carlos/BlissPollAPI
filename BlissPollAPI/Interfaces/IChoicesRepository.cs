using BlissPollAPI.Model;

namespace BlissPollAPI.Interfaces
{
	public interface IChoicesRepository : IRepository<Choices>
	{
		Task<List<Choices>> GetAllByPoll(int pollId);
	}
}
