using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace andculture_interview_api.Models
{
    public class OpenBrew
    {
        public OpenBrew()
        {
            Breweries = new List<Brewery>();
        }

        public List<Brewery> Breweries { get; set; }
    }
}