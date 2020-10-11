using Newtonsoft.Json;

namespace country_names.Models
{
    public class CountryCurrencies
    {
        [JsonProperty("code")]
        public string CurrencyCode { get; set; }
        [JsonProperty("name")]
        public string CurrencyName { get; set; }
        [JsonProperty("symbol")]
        public string CurrencySymbol { get; set; }
    }
}
