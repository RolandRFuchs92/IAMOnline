using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
	public class BlogType
	{
		[Key]
		public int BlogTypeId { get; set; }
		public string BlogName { get; set; }
	}
}