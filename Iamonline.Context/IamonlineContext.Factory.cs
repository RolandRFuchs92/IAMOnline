using Iamonline.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Iamonline.Data
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
