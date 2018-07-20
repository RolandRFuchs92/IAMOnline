using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Iamonline.Entity
{
	public class BlogType
	{
		[Key]
		public int BlogTypeId { get; set; }
		public string BlogName { get; set; }

		public List<BlogDetail> BlogDetail { get; set; }
	}
}