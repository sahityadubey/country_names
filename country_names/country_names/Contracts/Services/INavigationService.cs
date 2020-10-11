using country_names.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace country_names.Contracts.Services
{
    public interface INavigationService
    {
        bool IsMasterPagePresented { get; }

        Task InitializeAsync();

        Task NavigateToAsync<TViewModel>(object parameter = null) where TViewModel : ViewModelBase;

        Task NavigateToAsync(Type viewModelType, object parameter = null);

        Task NavigateToAsync(string pageName, object parameter = null);

        Task NavigateBackAsync();

        Task RemoveLastFromBackStackAsync();

        Task PopToRootAsync();
    }
}
