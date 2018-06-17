using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Entities
{
    public class AddressCountry
    {
		[Key]
	    public int AddressCountryId { get; set; }
	    public string CountryName { get; set; }
	    public string CountryCode { get; set; }
    }
}
