using country_names.ViewModels;
using country_names.Views;
using System;
using System.Collections.Generic;

namespace country_names.Services
{
    public partial class AppSetup
    {
        public static void CreatePageViewModelMappings(Dictionary<Type, Type> mappings)
        {
            mappings.Add(typeof(CountryListViewModel), typeof(MainPage));
        }
    }
}
