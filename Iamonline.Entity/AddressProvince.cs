using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Iamonline.Entity
{
    public class AddressProvince
    {
		[Key]
	    public int AddressProvinceId { get; set; }
	    public string ProvinceName { get; set; }

	    public List<Address> Address { get; set; }
    }
}
