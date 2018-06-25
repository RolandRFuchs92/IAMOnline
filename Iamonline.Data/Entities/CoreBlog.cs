using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Iamonline.Data.Entities
{
    public class CoreBlog
    {
		public int CoreBlogId { get; set; }
	    public int BlogDetailId { get; set; }
		public int CoreMemberId { get; set; }
	    public DateTime CreatedOn { get; set; }
	    public bool IsDeleted { get; set; }
	    public bool IsActive { get; set; }

		[ForeignKey("BlodDetailId")]
	    public BlogDetail BlogDetail { get; set; }
		[ForeignKey("CoreMemberId")]
	    public CoreMember CoreMember { get; set; }
	}
}
