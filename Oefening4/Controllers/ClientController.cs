using Microsoft.AspNetCore.Mvc;
using Oefening4.Data;
using Oefening4.Models;

namespace Oefening4.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            var clients = Database.Clients;
            return View(clients);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Client c = new Client();
            return View(c);
        }


        [HttpPost]
        public IActionResult Create(Client c)
        {
            if (c != null)
            {            
                var clients = Database.Clients;
                if (clients.Any(x => x.ClientID == c.ClientID))
                {
                    ModelState.AddModelError("ClientId", "ClientId already exists");
                    return View(c);
                }
                Database.AddClient(c);
                return RedirectToAction("Index", "Client");
            }
            return View();
           
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var clients = Database.Clients.FirstOrDefault(x => x.ClientID == id);
            Database.Clients.Remove(clients);
            return RedirectToAction("Index");
        }


    }
}
