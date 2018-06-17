using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DataAccess.Repository
{
    public class SiteDbRepository  //<T> where T : class
	    : ISiteDbRepository
    {
	    private readonly SiteDb _db;

	    private readonly ILogger<SiteDbRepository> _logger;
	    //private DbSet<T> _dbSet;

	    public SiteDbRepository(SiteDb db, ILogger<SiteDbRepository>  Logger)
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
