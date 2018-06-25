using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Iamonline.Data.Entities
{
    public class Client
    {
	    public int ClientId { get; set; }
	    public string ClientName { get; set; }
	    public int AddressId { get; set; }
	    public DateTime CreatedOn { get; set; }
	    public bool IsActive { get; set; }

		[ForeignKey("AddressId")]
	    public Address Address { get; set; }
	    public ICollection<CoreMember> CoreMembers { get; set; }
    }
}
