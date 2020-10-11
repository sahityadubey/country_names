namespace country_names.Contracts.Services
{
    public interface IDependencyService
    {
        T Get<T>() where T : class;
    }
}
