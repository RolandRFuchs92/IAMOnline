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
	    public int ProvinceId { get; set; }
	    public string ProvinceName { get; set; }
    }
}
