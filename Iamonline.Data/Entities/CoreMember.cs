using System.ComponentModel.DataAnnotations;

namespace Iamonline.Data.Entities
{
    public class CoreMember
    {
		[Key]
	    public int CoreMemberId { get; set; }
	    public Person Person { get; set; }
		public Client Client { get; set; }
    }
}
