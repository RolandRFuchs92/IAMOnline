using System;
using System.Collections.Generic;

namespace Iamonline.Data.Entities
{
    public class Client
    {
	    public int ClientId { get; set; }
	    public string ClientName { get; set; }
	    public int AddressId { get; set; }
	    public DateTime CreatedOn { get; set; }
	    public bool IsActive { get; set; }

	    public Address Address { get; set; }

	    public ICollection<CoreMember> CoreMembers { get; set; }
    }
}
