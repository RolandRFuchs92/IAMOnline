using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using DataAccess.Entities;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;

namespace DataAccess.Seed
{
    public class SiteDbSeeder
    {
	    private readonly SiteDb _db;
	    private readonly IHostingEnvironment _hosting;

	    public SiteDbSeeder(SiteDb db, IHostingEnvironment hosting)
	    {
		    _db = db;
		    _hosting = hosting;
	    }

	    public void Seed()
	    {
		    _db.Database.EnsureCreated();

		    if (!_db.BlogDetails.Any())
		    {

			    var filePath = Path.Combine(_hosting.ContentRootPath, "Seed/DefaultData/BlogDetails.json");
			    var json = File.ReadAllText(filePath);
			    var details = JsonConvert.DeserializeObject<IEnumerable<BlogDetail>>(json);

				_db.BlogDetails.AddRange(details);

		    }
	    }

    }
}
