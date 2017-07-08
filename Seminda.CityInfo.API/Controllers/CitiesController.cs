using Microsoft.AspNetCore.Mvc;
using Seminda.CityInfo.API.Data;
using System.Linq;

namespace Seminda.CityInfo.API.Controllers
{
    public class CitiesController:Controller 
    {
        [HttpGet("api/cities")]
        public IActionResult GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);
        }
        
        [HttpGet("api/cities/{id}")]
        public IActionResult GetCity(int id)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if (city == null)
            {
                return NotFound();
            }
            return Ok(city);
        }
    }
}
