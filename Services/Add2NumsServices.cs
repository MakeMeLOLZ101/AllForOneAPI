using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class Add2NumsServices
    {
        public string AddNumbers(int num1, int num2)
        {
            return $"The sum of {num1} and {num2} is {num1 + num2}.";
        }
    }
}