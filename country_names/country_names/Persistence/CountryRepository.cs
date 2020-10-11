using country_names.Constants;
using country_names.Contracts.Repository;
using country_names.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace country_names.Persistence
{
    public class CountryRepository : ICountryRepository
    {

        public CountryRepository()
        {
        }

        public async Task<IEnumerable<Countries>> GetAllCountries()
        {
            try
            {
                var client = new HttpClient();
                var json = await client.GetStringAsync(string.Format(ApiConstants.BaseApiUrl, "all"));
                return JsonConvert.DeserializeObject<List<Countries>>(json.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }

        public async Task<Countries> GetCountryByName(string countryCode)
        {
            try
            {
                var client = new HttpClient();
                var json = await client.GetStringAsync(string.Format(ApiConstants.BaseApiUrl, "alpha/" + countryCode));
                return JsonConvert.DeserializeObject<Countries>(json.ToString());
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
