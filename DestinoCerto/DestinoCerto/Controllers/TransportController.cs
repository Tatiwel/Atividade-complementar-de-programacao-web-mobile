using System;
using System.Collections.Generic;
using System.Web.Mvc;
using DestinoCerto.Models;

namespace DestinoCerto.Controllers
{
    public class TransportController : Controller
    {
        private static List<Transport> transportList = new List<Transport>();

        // GET: Transport/Register
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Transport transport)
        {
            if (ModelState.IsValid)
            {
                transportList.Add(transport);

                return RedirectToAction("Menu", "User");
            }

            return View(transport);
        }
    }
}
