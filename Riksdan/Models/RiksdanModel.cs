using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Riksdan.Models
{
    public class RiksdanModel
    {
        public class Person
        {
            [JsonProperty("fodd_ar")]
            public string BirthYear { get; set; }
            [JsonProperty("efternamn")]
            public string LastName { get; set; }
            [JsonProperty("tilltalsnamn")]
            public string FirstName { get; set; }
            [JsonProperty("sorteringsnamn")]
            public string SortName { get; set; }
            [JsonProperty("parti")]
            public string Party { get; set; }
            [JsonProperty("bild_url_80")]
            public string ImageUrlSmall { get; set; }
            [JsonProperty("bild_url_192")]
            public string ImageUrlLarge { get; set; }
        }

        public class PersonList
        {
            [JsonProperty("person")]
            public List<Person> Persons { get; set; }
        }

        public class JsonData
        {
            [JsonProperty("personlista")]
            public PersonList JsonObject { get; set; }
        }
    }
}
