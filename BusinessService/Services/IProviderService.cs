namespace BusinessService;

public interface IProviderService
{
 IEnumerable<Provider> GetProviders();
 Provider GetProviderById(int id);
 Provider AddProvider(Provider provider);
}
