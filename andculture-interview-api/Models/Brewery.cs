using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace andculture_interview_api.Models
{
    public class Brewery
    {
        public Brewery()
        {
            Tag_list = new List<string>();
        }
        public int id { get; set; }
        public string name { get; set; }
        [JsonPropertyName("brewery_type")]
        public string Brewery_type { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        [JsonPropertyName("postal_code")]
        public string Postal_code { get; set; }
        public string country { get; set; }
        public string longitude { get; set; }
        public string latitude { get; set; }
        public string phone { get; set; }
        [JsonPropertyName("website_url")]
        public string Website_url { get; set; }
        [JsonPropertyName("update_at")]
        public DateTime Updated_at { get; set; }
        [JsonPropertyName("tag_list")]
        public List<string> Tag_list { get; set; }
    }
}
