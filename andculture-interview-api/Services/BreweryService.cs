using andculture_interview_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace andculture_interview_api.Services
{
    public class BreweryService : IBreweryService
    {
        private readonly IBreweryRepository _breweryRepository;
        public BreweryService(IBreweryRepository breweryRepository)
        {
            _breweryRepository = breweryRepository;
        }
        public async Task<OpenBrewDto> GetBreweries()
        {
            var breweries = await _breweryRepository.GetBreweries();
            var breweriesDto = new OpenBrewDto(breweries);

            return breweriesDto;
        }
    }
}
