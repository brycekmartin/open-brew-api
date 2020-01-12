using andculture_interview_api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace andculture_interview_api.Models
{
    public class OpenBrewDto
    {
        //private IBreweryRepository _breweryRepository;
        public OpenBrewDto(/*IBreweryRepository breweryRepository*/)
        {
            Breweries = new List<BreweryDto>();
            //_breweryRepository = breweryRepository;
        }

        public OpenBrewDto(List<Brewery> breweries)
        {
            Breweries = new List<BreweryDto>();
            foreach(var brewery in breweries)
            {
                var breweryDto = new BreweryDto()
                {
                    id = brewery.id,
                    name = brewery.name,
                    breweryType = brewery.Brewery_type,
                    street = brewery.street,
                    city = brewery.city,
                    state = brewery.state,
                    postalCode = brewery.Postal_code,
                    country = brewery.country,
                    longitude = float.Parse(brewery.longitude),
                    latitude = float.Parse(brewery.latitude),
                    phone = brewery.phone,
                    websiteUrl = brewery.Website_url
                };
                Breweries.Add(breweryDto);
            }
        }
        public List<BreweryDto> Breweries { get; set; }

        //public async Task Load()
        //{
        //    var breweries = await _breweryRepository.GetBreweries();

        //    foreach (var brewery in breweries.Breweries)
        //    {
        //        var breweryDto = new BreweryDto()
        //        {
        //            id = brewery.id,
        //            name = brewery.name,
        //            brewery_type = brewery.brewery_type,
        //            street = brewery.street,
        //            city = brewery.city,
        //            postal_code = brewery.postal_code,
        //            country = brewery.country,
        //            longitude = brewery.longitude,
        //            latitude = brewery.latitude,
        //            phone = brewery.phone,
        //            website_url = brewery.website_url
        //        };
        //        Breweries.Add(breweryDto);
        //    };
        //}
    }
}
