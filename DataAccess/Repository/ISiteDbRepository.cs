using System.Collections.Generic;
using DataAccess.Entities;

namespace DataAccess.Repository
{
	public interface ISiteDbRepository
	{
		IEnumerable<AddressCountry> AddressCountries();
		IEnumerable<AddressCountry> GetAddressCountriesByCountry(string country);
	}
}