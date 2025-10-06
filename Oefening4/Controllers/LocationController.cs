using Microsoft.AspNetCore.Mvc;
using Oefening4.Data;
using Oefening4.Models;

namespace Oefening4.Controllers
{
    public class LocationController : Controller
    {
        public IActionResult Index()
        {
            var locations = Database.Locations;
            return View(locations);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Location location = new Location();
            return View(location);
        }

        [HttpPost]
        public IActionResult Create(Location l)
        {
            if (l != null)
            {
                if (ModelState.IsValid)
                {
                    var locations = Database.Locations;
                    var locationID = locations.Max(x => x.LocationID) + 1;
                    l.LocationID = locationID;
                    Database.AddLocation(l);
                    return RedirectToAction("Index", "Location");
                }         
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var locations = Database.Locations.FirstOrDefault(x => x.LocationID == id);
            Database.Locations.Remove(locations);
            return RedirectToAction("Index");
        }

    }
}
