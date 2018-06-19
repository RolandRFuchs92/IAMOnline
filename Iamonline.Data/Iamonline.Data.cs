using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DataAccess
{
	public class SiteDbFactory : IDesignTimeDbContextFactory<SiteDb>
	{
		public SiteDb CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<SiteDb>();
			optionsBuilder.UseSqlServer("server=MSI\\SQLEXPRESS;Database=SiteDb;Integrated Security=true;MultipleActiveResultSets=true;");

			return new SiteDb(optionsBuilder.Options);
		}
	}
}
