using BlissPollAPI.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace BlissPollAPI.Repository
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }
		
		public DbSet<Poll> Polls { get; set; }
		public DbSet<Choices> Choices { get; set; }
	}
}
