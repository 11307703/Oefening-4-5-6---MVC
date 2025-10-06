using Microsoft.AspNetCore.Mvc;
using Oefening4.Models;

namespace Oefening4.Controllers
{
    public class OverviewController : Controller
    {
        public IActionResult Index()
        {
            var overView = ClientLocation.OverView();
            return View(overView);
        }
    }
}
