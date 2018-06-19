using System.ComponentModel.DataAnnotations;

namespace Iamonline.Data.Entities
{
    public class AddressProvince
    {
		[Key]
	    public int AddressProvinceId { get; set; }
	    public string ProvinceName { get; set; }
    }
}
