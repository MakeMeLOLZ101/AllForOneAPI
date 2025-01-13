using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class MadlibServices
    {
        public string MadLib(string name, string noun, string verb, string adjective, string occupation )
        {
            return $"{name} decided not to {verb} that morning because they knew that {name} the {occupation} would be coming in today. With not much time to {verb} as the {noun} was {adjective}, they could at least stop the {adjective} {adjective}, otherwise the house would be {verb}.";
        }
    }
}