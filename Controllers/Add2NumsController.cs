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
    public class Add2NumsController : ControllerBase
    {
        private readonly Add2NumsServices _addTwoNumsServices;

        public Add2NumsController(Add2NumsServices add2NumsServices)
        {
            _addTwoNumsServices = add2NumsServices;
        }

        [HttpGet("add")]
        public string AddTwoNumbers([FromQuery] int num1, [FromQuery] int num2)
        {
            return _addTwoNumsServices.AddNumbers(num1, num2);
        }
    }
}