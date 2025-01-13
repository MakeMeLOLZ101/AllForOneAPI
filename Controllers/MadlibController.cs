using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AllForOneAPI.Services;

namespace AllForOneAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MadlibController : ControllerBase
    {
        private readonly MadlibServices _madlibServices;

        public MadlibController(MadlibServices madlibServices)
        {
            _madlibServices = madlibServices;
        }

        [HttpGet("{name}/{noun}/{adjective}/{verb}/{occupation}")]
        public ActionResult<string> Message(string name, string noun, string adjective, string verb, string occupation)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(noun) || string.IsNullOrEmpty(adjective) || string.IsNullOrEmpty(verb) || string.IsNullOrEmpty(occupation))
            {
                return BadRequest("Please fill it out properly");
            }

            var message = _madlibServices.MadLib(name, noun, verb, adjective, occupation);
            return Ok(message);
        }
    }
}