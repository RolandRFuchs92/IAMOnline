using System.ComponentModel.DataAnnotations;

namespace Iamonline.Data.Entities
{
    public class Person
    {
	    public int PersonId { get; set; }
	    public string PersonName { get; set; }
	    public string PersonSurname { get; set; }
	    public string PersonIdentityNumber { get; set; }
	    public string PersonEmail { get; set; }
	    public string PersonMobile { get; set; }
	    public string PersonHome { get; set; }
	    public string PersonWork { get; set; }
	    public int AddressId { get; set; }

	    public Address Address { get; set; }
	    public CoreMember CoreMember { get; set; }
    }
}
