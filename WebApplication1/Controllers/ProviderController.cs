using BusinessService;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1;

[Route("[controller]")]
public class ProviderController: Controller
{
    private readonly  IProviderService _providerService;
    public ProviderController(IProviderService providerService)
    {
        _providerService =providerService;
    }
    [HttpGet]
    public IActionResult GetAllProviders()
    {
        try{
        var providers = _providerService.GetProviders();
        return Ok(providers);
        }catch(Exception ex){
            return StatusCode(500,"Exception : "+ ex);
        }
            
    }

    [HttpGet("id")]
    public IActionResult GetProviderById(int Pid)
    {
         try{
        var providers = _providerService.GetProviderById(Pid);
        return Ok(providers);
        }catch(Exception ex){
        return StatusCode(500,"Exception : "+ ex);
        }
    }
    [HttpPost]
    public IActionResult AddProvider(Provider provider)
    {
        return Ok();
    }
    [HttpDelete("id")]
    public IActionResult ProviderDelete(int id)
    {
        return Ok();
    }
    
}
