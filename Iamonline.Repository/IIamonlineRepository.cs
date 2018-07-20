using System.Collections.Generic;
using Iamonline.Entity;

namespace Iamonline.Repository
{
	public interface IIamonlineRepository
	{
		IEnumerable<AddressCountry> AddressCountries();
		IEnumerable<AddressCountry> GetAddressCountriesByCountry(string country);
	}
}