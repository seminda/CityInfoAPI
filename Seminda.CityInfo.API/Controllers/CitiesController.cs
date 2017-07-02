using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Seminda.CityInfo.API.Controllers
{
    public class CitiesController:Controller 
    {
        [HttpGet("api/cities")]
        public JsonResult GetCities()
        {
            return new JsonResult(new List<Object>
            {
                new {Id=1, Name="Melbourne"},
                new {Id=2, Name="Sydney"}
            });
        }
    }
}
