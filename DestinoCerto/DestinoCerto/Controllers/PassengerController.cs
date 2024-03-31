using System;
using System.Collections.Generic;
using System.Web.Mvc;
using DestinoCerto.Models;

namespace DestinoCerto.Controllers
{
    public class PassengerController : Controller
    {
        // Lista para armazenar os passageiros cadastrados
        private static List<Passenger> passengers = new List<Passenger>();

        // GET: Passenger/Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: Passenger/Register
        [HttpPost]
        public ActionResult Register(Passenger passenger)
        {
            if (ModelState.IsValid)
            {
                // Adicionar o passageiro à lista
                passengers.Add(passenger);
                // Redirecionar para a página de menu
                return RedirectToAction("Menu", "User");
            }

            // Se houver erros de validação, retornar à página de registro
            return View(passenger);
        }
    }
}
