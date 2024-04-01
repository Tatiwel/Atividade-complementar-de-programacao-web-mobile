using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DestinoCerto.Models;

namespace DestinoCerto.Controllers
{
    public class PassengerController : Controller
    {
        private static List<Passenger> passengers = new List<Passenger>();

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Passenger passenger)
        {

            if (passengers.Any(p => p.Cpf == passenger.Cpf))
            {
                ModelState.AddModelError("Cpf", "Já existe um passageiro cadastrado com este CPF.");
            }

            if (ModelState.IsValid)
            {

                passengers.Add(passenger);
                return RedirectToAction("Menu", "User");
            }
            return View(passenger);
        }
    }
}
