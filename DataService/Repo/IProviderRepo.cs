namespace DataService;

public interface IProviderRepo
{
    Task<IEnumerable<Provider>> GetAllProviders();
    Task<Provider> GetProviderById(int id);
    Task<Provider> AddProvider();


}
