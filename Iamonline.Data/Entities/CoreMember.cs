using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Entities
{
    public class CoreMember
    {
		[Key]
	    public int CoreMemberId { get; set; }
	    public Person Person { get; set; }
    }
}
