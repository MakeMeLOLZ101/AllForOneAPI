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
    public class ReverseItAlphaController : ControllerBase
    {
        private readonly ReverseItAlphaServices _reverseItAlphaServices;

        public ReverseItAlphaController(ReverseItAlphaServices reverseItAlphaServices)
        {
            _reverseItAlphaServices = reverseItAlphaServices;
        }

        [HttpGet]
        [Route("ReverseItAlpha/{inputString}")]
        public string ReverseItAlpha(string inputString)
        {
            return _reverseItAlphaServices.ReverseItAlpha(inputString);
        }
    }
}