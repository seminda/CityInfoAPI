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
                    Description="Melbourne is the coastal capital of the southeastern Australian state of Victoria",
                    PointOfInterest=new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto
                        {
                            Id=1,
                            Name="Great Ocean Road",
                            Description="The Great Ocean Road is an Australian National Heritage listed 243 kilometres stretch of road along the south-eastern coast of Australia between the Victorian cities of Torquay and Allansford."
                        },
                        new PointOfInterestDto
                        {
                            Id=2,
                            Name="Shrine of Remembrance",
                            Description="The Shrine of Remembrance, located in Kings Domain on St Kilda Road, Melbourne, Australia was built as a memorial to the men and women of Victoria who served in World War I and is now a memorial to all Australians who have served in war."
                        }
                    }
                },
                new CityDto
                {
                    Id=2,
                    Name="Sydney",
                    Description="Sydney, capital of New South Wales",
                    PointOfInterest=new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto
                        {
                            Id=1,
                            Name="Sydney Opera House",
                            Description="The Sydney Opera House is a multi-venue performing arts centre in Sydney, Australia. It is one of the 20th century's most famous and distinctive buildings."
                        },
                        new PointOfInterestDto
                        {
                            Id=2,
                            Name="Darling Harbour",
                            Description="Darling Harbour is a harbour adjacent to the city centre of Sydney, New South Wales, Australia."
                        }
                    }
                },
                new CityDto
                {
                    Id=3,
                    Name="Brisbane",
                    Description="Brisbane, capital of Queensland",
                    PointOfInterest=new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto
                        {
                            Id=1,
                            Name="Story Bridge",
                            Description="The Story Bridge is a heritage-listed steel cantilever bridge spanning the Brisbane River that carries vehicular, bicycle and pedestrian traffic between the northern and the southern suburbs of Brisbane, Queensland, Australia."
                        },
                        new PointOfInterestDto
                        {
                            Id=2,
                            Name="Lone Pine Koala Sanctuary",
                            Description="Lone Pine Koala Sanctuary is an 18-hectare Koala Sanctuary in the Brisbane suburb of Fig Tree Pocket in Queensland, Australia. Founded in 1927, it is the world's oldest and largest koala sanctuary."
                        }
                    }
                }
            };
        }
    }
}
