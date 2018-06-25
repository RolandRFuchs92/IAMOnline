using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Iamonline.Data.Entities
{
    public class AddressProvince
    {
	    public int AddressProvinceId { get; set; }
	    public string ProvinceName { get; set; }

	    public Address Address { get; set; }
    }
}
