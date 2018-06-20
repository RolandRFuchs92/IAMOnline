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

		public AddressCountry AddressCountry { get; set; }
		public AddressProvince AddressProvince { get; set; }
		public AddressStreet AddressStreet { get; set; }
	    public Person Person { get; set; }
	}
}
