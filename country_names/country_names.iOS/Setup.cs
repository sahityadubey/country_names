using Autofac;
using country_names.Services;

namespace country_names.iOS
{
    public class Setup : AppSetup
    {
        protected override void RegisterDependencies(ContainerBuilder builder)
        {
            base.RegisterDependencies(builder);
        }
    }
}