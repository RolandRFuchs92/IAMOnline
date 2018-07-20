using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Iamonline.Entity
{
    public class AddressCountry
    {
		[Key]
	    public int AddressCountryId { get; set; }
	    public string CountryName { get; set; }
	    public string CountryCode { get; set; }

	    public List<Address> Address { get; set; }
    }
}
