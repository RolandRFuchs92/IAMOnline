using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Context
{
	public class SiteDb : DbContext
	{
		public SiteDb(DbContextOptions<SiteDb> options) : base(options)
		{
		}

		public DbSet<BlogType> BlogTypes { get; set; }
		public DbSet<BlogDetail> BlogDetails { get; set; }
		public DbSet<AddressCountry> AddressCountries{ get; set; }

	}
}
