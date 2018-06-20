﻿using System.ComponentModel.DataAnnotations;

namespace Iamonline.Data.Entities
{
    public class CoreMember
    {
	    public int CoreMemberId { get; set; }
	    public int PersonId { get; set; }
	    public int ClientId { get; set; }

	    public Person Person { get; set; }
		public Client Client { get; set; }
    }
}
