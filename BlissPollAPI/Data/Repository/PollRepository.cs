using BlissPollAPI.Interfaces;
using BlissPollAPI.Model;

namespace BlissPollAPI.Data.Repository
{
	public class PollRepository : Repository<Poll>, IPollRepository
	{
		private DataContext _context;

		public PollRepository(DataContext context) : base(context) 
		{
			_context = context;
		}

		public async Task<List<Poll>> GetPolls()
		{
			return await _context.Polls
				.Include(c => c.Choices)
				.ToListAsync();
		}
	}
}
