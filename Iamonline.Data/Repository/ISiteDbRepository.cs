using System.Collections.Generic;
using Iamonline.Data.Entities;

namespace Iamonline.Data.Repository
{
	public interface ISiteDbRepository
	{
		IEnumerable<AddressCountry> AddressCountries();
		IEnumerable<AddressCountry> GetAddressCountriesByCountry(string country);
	}
}