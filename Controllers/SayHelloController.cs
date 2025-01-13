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
    public class SayHelloController : ControllerBase
    {
        [HttpGet("{name}")]
        public string SayHello(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return "Please provide a name!";
            }

            return $"Hello, {name}!";
        }
    }
}