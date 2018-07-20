using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Iamonline.Context
{
    public class IamonlineContext : DbContext
    {
		public IamonlineContext(DbContextOptions<IamonlineContext> options) : base(options) {
	    }


    }
}
