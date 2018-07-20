using System.Collections.Generic;
using System.Linq;
using Iamonline.Data.Context;
using Iamonline.Data.Entities;
using Microsoft.Extensions.Logging;

namespace Iamonline.Data.Repository
{
	public class SiteDbRepository  : ISiteDbRepository
	{
		private readonly SiteDb _db;

		private readonly ILogger<SiteDbRepository> _logger;
		//private DbSet<T> _dbSet;

		public SiteDbRepository(SiteDb db, ILogger<SiteDbRepository> Logger)
		{
			_db = db;
			_logger = Logger;
			//_dbSet = _db.Set<T>();
		}

		public IEnumerable<AddressCountry> AddressCountries()
		{
			_logger.LogInformation("AddressCountries was called");
			return _db.AddressCountries
					.OrderBy(i => i.CountryName)
					.ToList();
		}

		public IEnumerable<AddressCountry> GetAddressCountriesByCountry(string country)
		{
			return _db.AddressCountries
					.Where(i => i.CountryName == country)
					.ToList();
		}

		public bool SaveAll()
		{
			return _db.SaveChanges() > 0;
		}

	}
}
