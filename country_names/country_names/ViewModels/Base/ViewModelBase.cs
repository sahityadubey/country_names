using country_names.Contracts.Repository;
using country_names.Contracts.Services;
using country_names.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace country_names.Base
{
    public class ViewModelBase : BindableBase, IDisposable
    {
        protected INavigationService NavigationService;
        protected ICountryRepository CountryRepository;
        protected ViewModelBase(
            INavigationService navigationService,
            ICountryRepository countryRepository)
        {
            NavigationService = navigationService;
            CountryRepository = countryRepository;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public virtual async Task InitializeAsync(object parameter)
        {
        }
    }
}