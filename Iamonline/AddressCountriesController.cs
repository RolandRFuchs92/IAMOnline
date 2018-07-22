using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Iamonline
{
	[Route("api/[Controller]")]
    public class AddressCountriesController : Controller
    {
        // GET: /<controller>/
		[HttpGet, Authorize]
        public IActionResult Get()
        {
	        try
	        {
		        return Ok(new {Moo = "moo"});
	        }
	        catch (Exception ex)
	        {
		        return BadRequest("There was an error.");
	        }
        }
    }
}
