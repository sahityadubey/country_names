using Newtonsoft.Json;
using System.Collections.Generic;

namespace country_names.Models
{
    public class Countries
    {
        [JsonProperty("name")]
        public string CountryName { get; set; }

        [JsonProperty("capital")]
        public string CountryCapital { get; set; }

        [JsonProperty("flag")]
        public string CountryFlag { get; set; }

        [JsonProperty("alpha3Code")]
        public string CountryCode { get; set; }

        [JsonProperty("currencies")]
        public List<CountryCurrencies> CountryCurrencies { get; set; }

      
        private string getCurrency;
        [JsonIgnore]
        public string GetCurrency
        {
            get
            {
                return CountryCurrencies[0].CurrencyName;
            }
            set
            {
                getCurrency = CountryCurrencies[0].CurrencyName;
            }
        }
    }
}
