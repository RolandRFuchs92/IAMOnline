using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace DataAccess.Entities
{
    public class Address
    {
		[Key]
	    public int AddressId { get; set; }
	    public AddressCountry AddressCountry { get; set; }
	    public AddressProvince AddressProvince{ get; set; }
	    public AddressStreet AddressStreet { get; set; }
    }
}
