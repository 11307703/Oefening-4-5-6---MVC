using Microsoft.AspNetCore.Mvc;

namespace Oefening4.Controllers
{
    public class LocationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
