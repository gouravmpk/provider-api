
namespace DataService;

public class ProviderRepo : IProviderRepo
{
    public Task<Provider> AddProvider()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Provider>> GetAllProviders()
    {
        throw new NotImplementedException();
    }

    public Task<Provider> GetProviderById(int id)
    {
        throw new NotImplementedException();
    }
}
