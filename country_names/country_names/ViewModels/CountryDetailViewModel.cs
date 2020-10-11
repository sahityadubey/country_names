using country_names.Base;
using country_names.Contracts.Repository;
using country_names.Contracts.Services;
using country_names.Models;
using System.Threading.Tasks;

namespace country_names.ViewModels
{
    public class CountryDetailViewModel : ViewModelBase
    {
        public CountryDetailViewModel(INavigationService navigationService, ICountryRepository countryRepository)
            : base(navigationService, countryRepository)
        {
            
        }

        public async Task<Countries> GetCountryById(string countryCode)
        {
            return await CountryRepository.GetCountryByName(countryCode);
        }
    }
}
