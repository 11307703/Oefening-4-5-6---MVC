using Microsoft.AspNetCore.Mvc;

namespace Oefening4.Controllers
{
    public class OverviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
