using Microsoft.AspNetCore.Mvc;

namespace BarcodeReaderForShoppingMobileApps.Controllers;

public class BarcodeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return Ok();
    }
    
}