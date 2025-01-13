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
    public class GreaterLessThanController : ControllerBase
    {
        private readonly GreaterLessThanServices _greaterLessThanServices;

        public GreaterLessThanController(GreaterLessThanServices greaterLessThanservices)
        {
            _greaterLessThanServices = greaterLessThanservices;
        }

        [HttpGet]
        [Route("compare/{firstNum}/{secondNum}")]
        public string CompareNums(double firstNum, double secondNum)
        {
            return _greaterLessThanServices.CompareNums(firstNum, secondNum);
        }
    }
}