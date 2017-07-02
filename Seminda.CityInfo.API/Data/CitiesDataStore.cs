using Seminda.CityInfo.API.Models;
using System.Collections.Generic;

namespace Seminda.CityInfo.API.Data
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>
            {
                new CityDto
                {
                    Id=1,
                    Name="Melbourne",
                    Description="Melbourne is the coastal capital of the southeastern Australian state of Victoria"
                },
                new CityDto
                {
                    Id=2,
                    Name="Sydney",
                    Description="Sydney, capital of New South Wales"
                },
                new CityDto
                {
                    Id=3,
                    Name="Brisbane",
                    Description="Brisbane, capital of Queensland"
                }
            };
        }
    }
}
