using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class GreaterLessThanServices
    {
        public string CompareNums(double firstNum, double secondNum)
        {
            if(firstNum > secondNum)
            {
                return $"{firstNum} is greater than {secondNum}";
            }
            else if(firstNum < secondNum)
            {
                return $"{firstNum} is less than {secondNum}";
            }
            else
            {
                return $"{firstNum} is equal to {secondNum}";
            }
        }
    }
}