using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Iamonline.Entity
{
    public class AddressStreet
    {
		[Key]
	    public int AddressStreetId { get; set; }
	    public string StreetName { get; set; }
	    public string PostalCode { get; set; }

	    public List<Address> Address { get; set; }
    }
}
