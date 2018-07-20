using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Iamonline.Entity
{
    public class Address
    {
		[Key]
	    public int AddressId { get; set; }
		public int AddressCountryId { get; set; }
		public int AddressProvinceId { get; set; }
		public int AddressStreetId { get; set; }

		[ForeignKey("AddressCountryId")]
		public virtual AddressCountry AddressCountry { get; set; }
		[ForeignKey("AddressProvinceId")]
		public virtual AddressProvince AddressProvince { get; set; }
		[ForeignKey("AddressStreetId")]
		public virtual AddressStreet AddressStreet { get; set; }
	}
}
