using System.ComponentModel.DataAnnotations;

namespace Iamonline.Data.Entities
{
	public class BlogType
	{
		public int BlogTypeId { get; set; }
		public string BlogName { get; set; }

		public BlogDetail BlogDetail { get; set; }
	}
}