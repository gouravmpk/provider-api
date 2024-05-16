
namespace BusinessService;

public class ProviderService :IProviderService
{
    private readonly List<Provider> _providers;

        public ProviderService()
        {
            _providers = new List<Provider>
            {
                new() { FName= "new",LName="sone",Services= ["Delivery"]},
                new() { FName = "something", LName = "Provider Two", Services = ["Cloud Storage"] }
            };
        }
        
    public Provider AddProvider(Provider provider)
    {
        throw new NotImplementedException();
    }

    public Provider GetProviderById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Provider> GetProviders()
    {
        return _providers; 
    }



}
