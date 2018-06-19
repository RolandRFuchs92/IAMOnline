using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Entities
{
    public class CoreBlog
    {
		[Key]
		public int CoreBlogId { get; set; }
	    public BlogDetail BlogDetail { get; set; }
	    public CoreMember CoreMember { get; set; }
	    public DateTime CreatedOn { get; set; }
	    public bool IsDeleted { get; set; }
	    public bool IsActive { get; set; }
	}
}
