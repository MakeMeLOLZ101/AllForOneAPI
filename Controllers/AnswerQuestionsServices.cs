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
    public class AnswerQuestionsController : ControllerBase
    {
        private readonly AnswerQuestionsServices _answerQuestionsServices;

        public AnswerQuestionsController(AnswerQuestionsServices answerQuestionsServices)
    {
        _answerQuestionsServices = answerQuestionsServices;
    }

    [HttpGet("{name}/{time}")]
    public ActionResult<string> GetInfo(string name, string time)
    {
        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(time))
        {
            return BadRequest("We need your name and wake-up time!!!");
        }

        var message = _answerQuestionsServices.WholeSentence(name, time);
        return Ok(message);
    }
    }
}