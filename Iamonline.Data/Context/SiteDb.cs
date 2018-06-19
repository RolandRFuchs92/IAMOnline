using Iamonline.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Iamonline.Data.Context
{
		public class SiteDb : DbContext
		{
				public SiteDb(DbContextOptions<SiteDb> options) : base(options)
				{
				}

				public DbSet<Address> Addresses { get; set; }
				public DbSet<AddressCountry> AddressCountries { get; set; }
				public DbSet<AddressProvince> AddressProvinces { get; set; }
				public DbSet<AddressStreet> AddressStreets { get; set; }
				public DbSet<BlogDetail> BlogDetails { get; set; }
				public DbSet<BlogType> BlogTypes { get; set; }
				public DbSet<Client> Clients { get; set; }
				public DbSet<CoreBlog> CoreBlogs { get; set; }
				public DbSet<CoreMember> CoreMembers { get; set; }
				public DbSet<Person> Persons { get; set; }
		}
}
