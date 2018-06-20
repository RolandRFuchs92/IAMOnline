using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Iamonline.Data.Entities
{
    public class AddressCountry
    {
	    public int AddressCountryId { get; set; }
	    public string CountryName { get; set; }
	    public string CountryCode { get; set; }

	    public Address Address { get; set; }
    }
}
