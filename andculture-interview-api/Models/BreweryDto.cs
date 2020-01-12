using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace andculture_interview_api.Models
{
    public class BreweryDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string breweryType { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }
        public float longitude { get; set; }
        public float latitude { get; set; }
        public string phone { get; set; }
        public string websiteUrl { get; set; }
    }
}
