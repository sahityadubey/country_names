using Autofac;
using country_names.Contracts.Repository;
using country_names.Contracts.Services;
using country_names.Persistence;
using country_names.Services.Other;
using country_names.ViewModels;

namespace country_names.Services
{
    public partial class AppSetup
    {
        public IContainer CreateContainer()
        {
            var builder = new ContainerBuilder();
            RegisterDependencies(builder);

            return builder.Build();
        }

        protected virtual void RegisterDependencies(ContainerBuilder builder)
        {
            // ViewModels
            builder.RegisterType<CountryListViewModel>().SingleInstance();

            // Services - General
            builder.RegisterType<DependencyService>().As<IDependencyService>();
            //builder.RegisterType<DialogService>().As<IDialogService>();
            builder.RegisterType<NavigationService>().As<INavigationService>();
            builder.RegisterType<CountryRepository>().As<ICountryRepository>();
            //builder.RegisterType<SettingsService>().As<ISettingsService>();

            // Services - Data
            //builder.RegisterType<RequestProvider>().As<IRequestProvider>();

            // Persistence
            //builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
        }
    }
}
