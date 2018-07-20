using System.Collections.Generic;
using Iamonline.Context;
using Iamonline.Entity;


namespace Iamonline.Data.Repository
{
	public interface ISiteDbRepository
	{
		IEnumerable<AddressCountry> AddressCountries();
		IEnumerable<AddressCountry> GetAddressCountriesByCountry(string country);
	}
}