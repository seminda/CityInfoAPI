using Microsoft.AspNetCore.Mvc;
using Seminda.CityInfo.API.Data;
using System;
using System.Collections.Generic;

namespace Seminda.CityInfo.API.Controllers
{
    public class CitiesController:Controller 
    {
        [HttpGet("api/cities")]
        public JsonResult GetCities()
        {
            return new JsonResult(CitiesDataStore.Current.Cities);
        }
    }
}
