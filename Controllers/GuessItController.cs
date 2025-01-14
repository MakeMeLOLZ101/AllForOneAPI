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
    public class GuessItController : ControllerBase
    {
        private readonly GuessItServices _guessItService;

        public GuessItController(GuessItServices guessItService)
        {
            _guessItService = guessItService;
        }

        [HttpGet]
        [Route("GuessNumberEasy/{userGuess}")]
        public string GuessItEasy(string userGuess)
        {
            return _guessItService.GuessItEasy(userGuess);
        }

        [HttpGet]
        [Route("GuessNumberMedium/{userGuess}")]
        public string GuessItMedium(string userGuess)
        {
            return _guessItService.GuessItMedium(userGuess);
        }

        [HttpGet]
        [Route("GuessNumberHard/{userGuess}")]
        public string GuessItHard(string userGuess)
        {
            return _guessItService.GuessItHard(userGuess);
        }
    }
}