using country_names.Base;
using country_names.Contracts.Repository;
using country_names.Contracts.Services;
using country_names.Extension;
using country_names.Models;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace country_names.ViewModels
{
    public class CountryListViewModel : ViewModelBase
    {
        private ObservableCollection<Countries> _countries;
        public ObservableCollection<Countries> Countries { get => _countries; set => SetProperty(ref _countries, value); }

        public CountryListViewModel(INavigationService navigationService, ICountryRepository countryRepository) 
            : base(navigationService, countryRepository)
        {
        }

        private void ExecuteListViewItemSelectedCommand()
        {
            NavigationService.NavigateToAsync<CountryDetailViewModel>(Countries[e.SelectedItemIndex].CountryCode);
        }

        public override async Task InitializeAsync(object parameter)
        {
            Countries = await CountryRepository.GetAllCountries().ToObservableCollectionAsync();
        }
    }
}
