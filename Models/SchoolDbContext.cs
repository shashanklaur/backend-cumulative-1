using Microsoft.EntityFrameworkCore;

namespace SchoolDatabase.Models
{
	public class SchoolDbContext : DbContext
	{
		public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options) { }

		public DbSet<Teacher> Teachers { get; set; }
	}
}
