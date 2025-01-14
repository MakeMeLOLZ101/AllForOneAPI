using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class RestaurantPickerServices
    {
        public string RestaurantMethod(string userChoice)
        {

            Random rng = new Random();
            bool numbersOnly = true;
            char[] charArray = userChoice.ToCharArray();
            string answer = "";

              for (int i = 0; i < charArray.Length; i++)
            {
                bool validation = int.TryParse(charArray[i].ToString(), out int convertedNum);

                if (validation != true)
                {
                    numbersOnly = false;
                }
               
            }

            if(numbersOnly == true)
            {
                return "Please use words not numbers";
            }
            else
            {


                if (userChoice.ToLower().Trim() == "italian")
                {

                    switch (rng.Next(11))
                    {
                        case 1:
                            answer = "Little Caesars";
                            break;
                        case 2:
                            answer = "Mario's corner";
                            break;
                        case 3:
                            answer = "Papa john's";
                            break;
                        case 4:
                            answer = "Domino's";
                            break;
                        case 5:
                            answer = "Luigi's ";
                            break;
                        case 6:
                           answer = "Galleto Ristorante";
                            break;
                        case 7:
                            answer = "Padella Italliana";
                            break;
                        case 8:
                            answer = "Olive Garden";
                            break;
                        case 9:
                            answer = "Wario's Hamburger & pizza";
                            break;
                        case 10:
                            answer = "WaLuigi's";
                            break;
                    }

                }
                else if (userChoice.ToLower().Trim() == "mexican")
                {
                     switch (rng.Next(11))
                        {
                            case 1:
                                answer = "El Jardin";
                                break;
                            case 2:
                                answer ="Taqueria GOKU";
                                break;
                            case 3:
                                answer = "Tortas El Chavo";
                                break;
                            case 4:
                                answer = "LOS CAZADORES TAQUERIA";
                                break;
                            case 5:
                                answer = "chipotle";
                                break;
                            case 6:
                                answer = "Taco Bell";
                                break;
                            case 7:
                                answer = "Las Casuelas";
                                break;
                            case 8:
                                answer = "Esmeralda's";
                                break;
                            case 9:
                                answer = "Taqueria La Costa";
                                break;
                            case 10:
                                answer = "Vegita's Tortas & Burritos";
                                break;
                        }
                }
                else if (userChoice.ToLower().Trim() == "dutch")
                {
                    
                    switch (rng.Next(11))
                        {
                            case 1:
                                answer = "Amsterdam, hamster-ham";
                                break;
                            case 2:
                                answer = "NederGANS";
                                break;
                            case 3:
                                answer = "De kas";
                                break;
                            case 4:
                               answer = "Moeders";
                                break;
                            case 5:
                                answer = "The Pantry";
                                break;
                            case 6:
                                answer = "Vis en Kip";
                                break;
                            case 7:
                                answer = "Grillby's";
                                break;
                            case 8:
                                answer = "Maccie";
                                break;
                            case 9:
                                answer = "Dutch Burger King";
                                break;
                            case 10:
                               answer = "Kentucky Gebakken Kip";
                                break;
                        }
                }
                else
                {
                    answer = "Please chose from our Categories:\nDutch\nMexican\nItalian";
                }




            }
                
            return answer;


        }
    }
}