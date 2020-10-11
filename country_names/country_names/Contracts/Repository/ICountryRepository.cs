using country_names.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace country_names.Contracts.Repository
{
    public interface ICountryRepository
    {
        Task<IEnumerable<Countries>> GetAllCountries();
        Task<Countries> GetCountryByName(string countryCode);
    }
}
