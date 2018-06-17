using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class Client
    {
	    public int ClientId { get; set; }
	    public string ClientName { get; set; }
	    public Address Address { get; set; }
	    public DateTime CreatedOn { get; set; }
	    public bool IsActive { get; set; }

		public ICollection<CoreMember> CoreMembers { get; set; }
    }
}
