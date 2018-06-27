using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Iamonline.Data.Entities
{
    public class CoreMember
    {
		[Key]
		//[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int CoreMemberId { get; set; }
	    public int PersonId { get; set; }
	    public int ClientId { get; set; }

		[ForeignKey("PersonId")]
	    public Person Person { get; set; }
		[ForeignKey("ClientId")]
		public Client Client { get; set; }
    }
}
