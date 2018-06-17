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
	    private readonly string _path;

	    public SiteDbSeeder(SiteDb db, IHostingEnvironment hosting)
	    {
		    _db = db;
		    _hosting = hosting;
			_path = Path.Combine(_hosting.ContentRootPath, "..\\DataAccess\\Seed\\DefaultData");
		}

	    public void Seed()
	    {
		    _db.Database.EnsureCreated();

		    if (!_db.AddressCountries.Any())
		    {
				_db.AddressCountries.AddRange(GetData<AddressCountry>("AddressCountry.json"));
			    _db.SaveChanges();
		    }
	    }

	    private IEnumerable<T> GetData<T>(string fileName)
	    {
		    var dataPath = GetRawDataPath(fileName);
		    var rawDataString = GetRawStringData(dataPath);
			return GetSerializedJsonObject<T>(rawDataString);
		}


	    private string GetRawDataPath(string fileName)
	    {
		    return Path.Combine(_path, fileName);
	    }

	    private string GetRawStringData(string dataPath)
	    {
			return File.ReadAllText(dataPath);
		}

	    private IEnumerable<T> GetSerializedJsonObject<T>(string rawStringData)
	    {
			return JsonConvert.DeserializeObject<IEnumerable<T>>(rawStringData);
		}

    }
}
