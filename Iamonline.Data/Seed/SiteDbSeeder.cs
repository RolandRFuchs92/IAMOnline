using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using DataAccess.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace DataAccess.Seed
{
		public class SiteDbSeeder
		{
				private readonly SiteDb _db;
				private readonly IHostingEnvironment _hosting;
				private readonly string _path;
				public static readonly MethodInfo _dbSetMethod = typeof(DbContext).GetMethods().Single(m => m.Name == "Set" && m.IsGenericMethod);


				public SiteDbSeeder(SiteDb db, IHostingEnvironment hosting)
				{
						_db = db;
						_hosting = hosting;
						_path = Path.Combine(_hosting.ContentRootPath, "..\\Iamonline.Data\\Seed\\DefaultData");
				}

				public void Seed()
				{
						_db.Database.EnsureCreated();

						//Address
						_db.AddressCountries.AddRange(GetData<AddressCountry>("AddressCountry.json"));
						_db.AddressProvinces.AddRange(GetData<AddressProvince>("AddressProvince.json"));
						_db.AddressStreets.AddRange(GetData<AddressStreet>("AddressStreet.json"));
						_db.Addresses.AddRange(GetData<Address>("Address.json"));

						//Blog
						_db.BlogDetails.AddRange(GetData<BlogDetail>("BlogDetail.json"));
						_db.BlogTypes.AddRange(GetData<BlogType>("BlogType.json"));
						_db.CoreBlogs.AddRange(GetData<CoreBlog>("CoreBlog.json"));

						//Person
						_db.Persons.AddRange(GetData<Person>("Person.json"));

						//CoreMembers
						_db.CoreMembers.AddRange(GetData<CoreMember>("CoreMember.json"));

						_db.SaveChanges();

				}

				private IEnumerable<T> GetData<T>(string fileName)
				{
						if (IsPopulatedDbSet<T>()) return null;

						var dataPath = GetRawDataPath(fileName);
						var rawDataString = GetRawStringData(dataPath);
						return GetSerializedJsonObject<T>(rawDataString);
				}

				private bool IsPopulatedDbSet<T>()
				{
						return ((IQueryable<T>)_dbSetMethod.MakeGenericMethod(typeof(T)).Invoke(_db, Array.Empty<object>())).Any();
				}

				private string GetRawDataPath(string fileName)
				{
						return Path.Combine(_path, fileName);
				}

				private string GetRawStringData(string dataPath)
				{
						return File.ReadAllText(dataPath);
				}

				private IEnumerable<T> GetSerializedJsonObject<T>(string rawStringData)
				{
						return JsonConvert.DeserializeObject<IEnumerable<T>>(rawStringData);
				}

		}
}
