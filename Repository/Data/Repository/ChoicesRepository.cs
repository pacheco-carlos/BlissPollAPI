using BlissPollAPI.Entities.Models;
using BlissPollAPI.Repository;
using BlissPollAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlissPollAPI.Data.Repository
{
	public class ChoicesRepository : Repository<Choices>, IChoicesRepository
	{
		private DataContext _context;

		public ChoicesRepository(DataContext context) : base(context) 
		{
			_context = context;
		}

		public async Task<List<Choices>> GetAllByPoll(int pollId)
		{
			return await _context.Choices.Where(c => c.Poll.Id.Equals(pollId)).ToListAsync();
		}
	}
}
