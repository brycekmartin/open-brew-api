using andculture_interview_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Reflection;

namespace andculture_interview_api.Services
{
    public class BreweryRepository : IBreweryRepository
    {
        public async Task<List<Brewery>> GetBreweries()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\openBrewDB.json");
            var jsonString = await File.ReadAllTextAsync(path);
            try
            {
                var jsonModel = JsonSerializer.Deserialize<List<Brewery>>(jsonString);
                return jsonModel;
            }
            catch(Exception e)
            {
                var error = e;
                return new List<Brewery>();
            }
            

            //return new OpenBrew();
            //return jsonModel;
        }

        public async Task<Brewery> GetBrewery(int id)
        {
            var breweries = await GetBreweries();
            var brewery = breweries.Where(x => x.id == id).FirstOrDefault();

            return brewery;
        }
    }
}
