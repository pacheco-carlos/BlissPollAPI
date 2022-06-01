using BlissPollAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace BlissPollAPI.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }
		
		public DbSet<Poll> Polls { get; set; }
		public DbSet<Choices> Choices { get; set; }
	}
}
