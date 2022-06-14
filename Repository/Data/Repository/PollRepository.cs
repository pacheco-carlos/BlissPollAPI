using BlissPollAPI.Entities.Models;
using BlissPollAPI.Repository;
using BlissPollAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlissPollAPI.Data.Repository
{
	public class PollRepository : Repository<Poll>, IPollRepository
	{
		private DataContext _context;

		public PollRepository(DataContext context) : base(context) 
		{
			_context = context;
		}

		public async Task<List<Poll>> GetPolls(QuestionParameters questionParameters)
		{
			return await _context.Polls
				.Include(c => c.Choices)
				.OrderBy(p => p.Published_At)
				.Skip((questionParameters.PageNumber - 1) * questionParameters.PageSize)
				.Take(questionParameters.PageSize)
				.ToListAsync();
		}
	}
}
