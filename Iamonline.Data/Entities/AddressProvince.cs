using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class AddressProvince
    {
		[Key]
	    public int AddressProvinceId { get; set; }
	    public string ProvinceName { get; set; }
    }
}
