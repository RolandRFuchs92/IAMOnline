using Iamonline.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Iamonline.Data
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
