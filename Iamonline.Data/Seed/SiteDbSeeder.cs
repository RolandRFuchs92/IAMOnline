using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Iamonline.Data.Context;
using Iamonline.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Iamonline.Data.Seed.Utilities;

namespace Iamonline.Data.Seed
{
	public class SiteDbSeeder
	{
		private readonly SiteDb _db;
		private readonly IHostingEnvironment _hosting;
		private readonly string _path;
		public static readonly MethodInfo _dbSetMethod = typeof(DbContext).GetMethods().Single(m => m.Name == "Set" && m.IsGenericMethod);
		private readonly GetData _getData;

		public SiteDbSeeder(SiteDb db, IHostingEnvironment hosting)
		{
			_db = db;
			_hosting = hosting;
			_path = Path.Combine(_hosting.ContentRootPath, "..\\Iamonline.Data\\Seed\\DefaultData");
			_getData = new GetData(_db, _hosting);
		}

		public void SeedDummyData()
		{
			//Address
			_db.AddressCountries.AddRange(_getData.GetEntities<AddressCountry>("AddressCountry.json"));
			_db.AddressProvinces.AddRange(_getData.GetEntities<AddressProvince>("AddressProvince.json"));
			_db.AddressStreets.AddRange(_getData.GetEntities<AddressStreet>("AddressStreet.json"));
			_db.SaveChanges();

			_db.Addresses.AddRange(_getData.GetEntities<Address>("Address.json"));
			_db.SaveChanges();

			//Person
			_db.Persons.AddRange(_getData.GetEntities<Person>("Person.json"));

			//Client
			_db.Clients.AddRange(_getData.GetEntities<Client>("Client.json"));

			//CoreMembers > FK PersonId and ClientId
			_db.CoreMembers.AddRange(_getData.GetEntities<CoreMember>("CoreMember.json"));
			_db.SaveChanges();

			//Blog
			_db.BlogDetails.AddRange(_getData.GetEntities<BlogDetail>("BlogDetail.json"));
			_db.CoreBlogs.AddRange(_getData.GetEntities<CoreBlog>("CoreBlog.json"));

			_db.SaveChanges();
		}

		public void SeedPersistedData()
		{
			_db.Database.EnsureCreated();

			//BlogTypes > these are persisted values
			_db.BlogTypes.AddRange(_getData.GetEntities<BlogType>("BlogType.json"));
			_db.SaveChanges();
		}

		

	}
}
