using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class GuessItServices
    {
        Random rng = new Random();

        public string GuessItEasy(string userGuess)
        {
           
            int easy = rng.Next(11);
            bool validation = int.TryParse(userGuess, out int convertedNum);

            if (validation != true)
            {
                return "numbers only bro";
            }


            if (convertedNum == easy)
            {
                return "You got it, not like it was that hard anyway";
            }
            else if (convertedNum > easy)
            {
                return "Way over the target dude, try going lower next time";
            }
            else if (convertedNum < easy)
            {
                return "Aim higher, dude";
            }

            return "you are not supposed to see this";

        }


         public string GuessItMedium(string userGuess)
        {
           
            int medium = rng.Next(51);
            bool validation = int.TryParse(userGuess, out int convertedNum);

            if (validation != true)
            {
                return "numbers only bro";
            }

            if (convertedNum == medium)
            {
                return "You got it dude! Nice!";
            }
            else if (convertedNum > medium)
            {
                return "Way over the target dude, try going lower next time";
            }
            else if (convertedNum < medium)
            {
                return "Aim higher, dude";
            }

            return "you are not supposed to see this";

        }


        public string GuessItHard(string userGuess)
        {
           
            int hard = rng.Next(101);
            bool validation = int.TryParse(userGuess, out int convertedNum);


            if (validation != true)
            {
                return "numbers only bro";
            }


            if (convertedNum == hard)
            {
                return "No way man! You got it!";
            }
            else if (convertedNum > hard)
            {
                return "Way over the target dude, try going lower next time";
            }
            else if (convertedNum < hard)
            {
                return "Aim higher, dude";
            }

            return "you are not supposed to see this";

        }
    }
}