using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class OddOrEvenServices
    {
        public string OddOrEven(string checkNum)
        {
            int convertedNum;
            bool isValid = int.TryParse(checkNum, out convertedNum);

            if(isValid && ((convertedNum % 2) == 0))
            {
                return $"{checkNum} is even!";
            } else if(isValid){
                return $"{checkNum} is odd!";
            } else {
                return "TYPE A NUMBER!!!";
            }
        }
    }
}