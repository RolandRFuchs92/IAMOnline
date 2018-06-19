using System.ComponentModel.DataAnnotations;

namespace Iamonline.Data.Entities
{
    public class Address
    {
		[Key]
	    public int AddressId { get; set; }
	    public AddressCountry AddressCountry { get; set; }
	    public AddressProvince AddressProvince{ get; set; }
	    public AddressStreet AddressStreet { get; set; }
    }
}
