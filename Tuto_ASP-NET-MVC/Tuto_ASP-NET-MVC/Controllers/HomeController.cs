using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tuto_ASP_NET_MVC.Models;

namespace Tuto_ASP_NET_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string id = "world")
        {
            if (string.IsNullOrWhiteSpace(id))
                return View("Error");
            else
                ViewBag.Nom = id;
                return View();
        }
        public ActionResult ListeClients()
        {
            Clients clients = new Clients();
            ViewData["Clients"] = clients.ObtenirListeClients();
            return View();
        }

        public ActionResult ChercheClient(string id)
        {
            ViewData["Nom"] = id;
            Clients clients = new Clients();
            Client client = clients.ObtenirListeClients().FirstOrDefault(c => c.Nom == id);
            if (client != null)
            {
                ViewData["Age"] = client.Age;
                return View("Trouve");
            }
            return View("NonTrouve");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Page de désciption de l'application web.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Page de contact du développeur.";

            return View();
        }
    } 
}