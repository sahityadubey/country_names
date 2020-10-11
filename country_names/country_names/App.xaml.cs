using country_names.Contracts.Services;
using country_names.Services;
using country_names.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace country_names
{
    public partial class App : Application
    {
        public App(AppSetup setup)
        {
            InitializeComponent();

            AppContainer.Container = setup.CreateContainer();

            InitializeNavigation();
        }

        private async void InitializeNavigation()
        {
            var navigationService = AppContainer.Resolve<INavigationService>();
            await navigationService.InitializeAsync();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
