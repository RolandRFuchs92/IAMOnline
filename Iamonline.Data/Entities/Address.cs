using System.ComponentModel.DataAnnotations;

namespace Iamonline.Data.Entities
{
    public class Address
    {
		[Key]
	    public int AddressId { get; set; }
		public int AddressCountryId { get; set; }
	    public int AddressProvinceId { get; set; }
		public int AddressStreetId { get; set; }

	    public AddressCountry AddressCountry { get; set; }
	    public AddressProvince AddressProvince{ get; set; }
	    public AddressStreet AddressStreet { get; set; }
    }
}
