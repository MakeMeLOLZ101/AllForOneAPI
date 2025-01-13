using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class AnswerQuestionsServices
    {
        public string WholeSentence(string name, string time)
        {
            return$"Hello {name}! You woke up at {time} today.";
        }
    }
}