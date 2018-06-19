using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Iamonline.Data.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Iamonline.Data.Seed.Utilities
{
    public class GetData
    {
	    private readonly SiteDb _db;
	    private IHostingEnvironment _hosting;
	    private string _path;
	    public static readonly MethodInfo _dbSetMethod = typeof(DbContext).GetMethods().Single(m => m.Name == "Set" && m.IsGenericMethod);

		public GetData(SiteDb db, IHostingEnvironment hosting)
	    {
		    _db = db;
		    _hosting = hosting;
		    _path = Path.Combine(_hosting.ContentRootPath, "..\\Iamonline.Data\\Seed\\DefaultData");
	    }

		public IEnumerable<T> GetEntities<T>(string fileName)
	    {
		    if (GetQueriableOfType<T>().Any()) return new List<T>();

		    var dataPath = GetRawDataPath(fileName);
		    var rawDataString = GetRawStringData(dataPath);
		    return GetSerializedJsonObject<T>(rawDataString);
	    }

		/// <summary>
		/// Get A querably object against the Database by type
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
	    private IQueryable<T> GetQueriableOfType<T>()
	    {
		    return (IQueryable<T>)_dbSetMethod.MakeGenericMethod(typeof(T)).Invoke(_db, Array.Empty<object>());
	    }

		/// <summary>
		/// Using the fileName get the path and combine it to the local path of the running project
		/// </summary>
		/// <param name="fileName"></param>
		/// <returns></returns>
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
