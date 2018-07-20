using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Iamonline.Context
{
	public class SiteDbFactory : IDesignTimeDbContextFactory<IamonlineContext>
	{
		public IamonlineContext CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<IamonlineContext>();
			optionsBuilder.UseSqlServer("server=MSI\\SQLEXPRESS;Database=SiteDb;Integrated Security=true;MultipleActiveResultSets=true;");

			return new IamonlineContext(optionsBuilder.Options);
		}
	}
}
