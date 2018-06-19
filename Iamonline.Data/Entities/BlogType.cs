using System.ComponentModel.DataAnnotations;

namespace Iamonline.Data.Entities
{
	public class BlogType
	{
		[Key]
		public int BlogTypeId { get; set; }
		public string BlogName { get; set; }
	}
}