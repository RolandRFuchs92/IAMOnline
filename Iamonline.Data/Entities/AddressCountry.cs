using System.ComponentModel.DataAnnotations;

namespace Iamonline.Data.Entities
{
    public class AddressCountry
    {
		[Key]
	    public int AddressCountryId { get; set; }
	    public string CountryName { get; set; }
	    public string CountryCode { get; set; }
    }
}
