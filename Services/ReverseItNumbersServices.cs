using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class ReverseItNumbersServices
    {
        public string ReverseItNumbers(string number)
        {
            int intNumber;
            string result = "";
            bool isInt = int.TryParse(number, out intNumber);
            if(isInt == true)
            {
                if(intNumber < 0)
                {
                    intNumber *= -1;
                    for(int i = number.Length - 1; i > 0; i--){
                        result += intNumber % 10;
                        intNumber /= 10;
                    }
                    return $"{result}-";
                } else {
                    for(int i = number.Length - 1; i >= 0; i--)
                    {
                        result += intNumber % 10;
                        intNumber /= 10;
                    }
                    return result;
                }
            } else {
                return "PLEASE TYPE IN A NUMBER, BUDDY!!!";
            }
        }
    }
}