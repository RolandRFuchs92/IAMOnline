using System.ComponentModel.DataAnnotations;

namespace Iamonline.Data.Entities
{
    public class AddressStreet
    {
		[Key]
	    public int AddressStreetId { get; set; }
	    public string StreetName { get; set; }
	    public string PostalCode { get; set; }
    }
}
