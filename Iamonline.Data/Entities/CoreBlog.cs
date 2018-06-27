using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Iamonline.Data.Entities
{
    public class CoreBlog
    {
		[Key]
		public int CoreBlogId { get; set; }
	    public int BlogDetailId { get; set; }
		public int CoreMemberId { get; set; }
	    public DateTime CreatedOn { get; set; }
	    public bool IsDeleted { get; set; }
	    public bool IsActive { get; set; }

		[ForeignKey("BlogDetailId")]
	    public BlogDetail BlogDetail { get; set; }
		[ForeignKey("CoreMemberId")]
	    public CoreMember CoreMember { get; set; }
	}
}
	