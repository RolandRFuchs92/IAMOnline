using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Iamonline.Data.Entities
{
    public class AddressStreet
    {
	    public int AddressStreetId { get; set; }
	    public string StreetName { get; set; }
	    public string PostalCode { get; set; }

	    public Address Address { get; set; }
    }
}
