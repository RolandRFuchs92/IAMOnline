using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Iamonline.Data.Entities
{
    public class Address
    {
	    public int AddressId { get; set; }
	    public int AddressCountryId { get; set; }
	    public int AddressProvinceId { get; set; }
	    public int AddressStreetId { get; set; }

		[ForeignKey("AddressCountryId")]
		public AddressCountry AddressCountry { get; set; }
		[ForeignKey("AddressProvinceId")]
		public AddressProvince AddressProvince { get; set; }
		[ForeignKey("AddressStreetId")]
		public AddressStreet AddressStreet { get; set; }
	}
}
