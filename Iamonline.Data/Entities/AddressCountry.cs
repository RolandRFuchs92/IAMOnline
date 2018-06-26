using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Iamonline.Data.Entities
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
