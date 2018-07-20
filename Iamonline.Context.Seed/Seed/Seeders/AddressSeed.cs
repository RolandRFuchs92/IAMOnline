using System.Collections.Generic;
using System.Linq;
using Iamonline.Entity;

namespace Iamonline.Context.Seed.Seed.Seeders
{
    public class AddressSeed
    {
	    private readonly IamonlineContext _db;

	    public AddressSeed(IamonlineContext _db)
	    {
		    this._db = _db;
	    }

	    public IEnumerable<Address> SetNewAddresses(IEnumerable<Address> addresses)
	    {
			//var addressList = (from i in addresses
			//					join b in _db.AddressCountries on i.AddressCountry)

			return new List<Address>();
	    }

	    private IQueryable<AddressCountry> GetAddressCountries()
	    {
		    return _db.AddressCountries;
	    }

	    private IQueryable<AddressProvince> GetAddressProvinces()
	    {
		    return _db.AddressProvinces;
	    }

	    private IQueryable<AddressStreet> GetAddressStreet()
	    {
		    return _db.AddressStreets;
	    }

    }
}
