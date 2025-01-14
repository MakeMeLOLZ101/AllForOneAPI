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
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerServices _restaurantPickerServices;

        public RestaurantPickerController(RestaurantPickerServices restaurantPickerServices)
        {
            _restaurantPickerServices = restaurantPickerServices;
        }
        

        [HttpGet]
        [Route("RestaurantPicker/{userChoice}")]
        public string RestaurantMethod(string userChoice)
        {
            return _restaurantPickerServices.RestaurantMethod(userChoice);
        }
    }
}