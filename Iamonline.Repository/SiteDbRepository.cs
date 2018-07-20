using System.Collections.Generic;
using System.Linq;
using Iamonline.Context;
using Iamonline.Entity;

namespace Iamonline.Data.Repository
{
    public class SiteDbRepository  //<T> where T : class
	    : ISiteDbRepository
    {
	    private readonly IamonlineContext _db;
	    //private DbSet<T> _dbSet;

	    public SiteDbRepository(IamonlineContext db)
	    {
		    _db = db;
		    //_dbSet = _db.Set<T>();
	    }

	    public IEnumerable<AddressCountry> AddressCountries()
	    {
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
