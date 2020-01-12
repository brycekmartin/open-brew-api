using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using andculture_interview_api.Models;

namespace andculture_interview_api.Services
{
    public interface IBreweryRepository
    {
        Task<List<Brewery>> GetBreweries();
        Task<Brewery> GetBrewery(int id);
    }
}
