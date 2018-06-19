using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class AddressStreet
    {
		[Key]
	    public int AddressStreetId { get; set; }
	    public string StreetName { get; set; }
	    public string PostalCode { get; set; }
    }
}
