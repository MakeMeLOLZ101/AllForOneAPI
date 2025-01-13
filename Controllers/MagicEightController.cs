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
    public class MagicEightController : ControllerBase
    {
        private readonly MagicEightServices _magicEightServices;

    public MagicEightController(MagicEightServices magicEightServices)
    {
        _magicEightServices = magicEightServices;
    }

    [HttpGet("ask")]
    public object GetAnswer([FromQuery] string question)
    {
        if (string.IsNullOrWhiteSpace(question))
        {
            return new { error = "Please provide a question" };
        }

        var answer = _magicEightServices.GetAnswer(question);
        return new { question, answer };
    }
    }
}