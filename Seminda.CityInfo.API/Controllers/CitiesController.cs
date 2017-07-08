using Microsoft.AspNetCore.Mvc;
using Seminda.CityInfo.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Seminda.CityInfo.API.Controllers
{
    public class CitiesController:Controller 
    {
        [HttpGet("api/cities")]
        public JsonResult GetCities()
        {
            return new JsonResult(CitiesDataStore.Current.Cities);
        }


        [HttpGet("api/cities/{id}")]
        public JsonResult GetCity(int id)
        {
            return new JsonResult(CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id));
        }
    }
}
