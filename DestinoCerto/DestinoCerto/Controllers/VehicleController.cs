using System;
using System.Collections.Generic;
using System.Web.Mvc;
using DestinoCerto.Models;

namespace DestinoCerto.Controllers
{
    public class VehicleController : Controller
    {
        // Lista para armazenar os veículos cadastrados
        private static List<Vehicle> vehicleList = new List<Vehicle>();

        // GET: Vehicle/Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: Vehicle/Register
        [HttpPost]
        public ActionResult Register(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                // Adiciona o veículo à lista (simulando a inserção no banco de dados)
                vehicleList.Add(vehicle);

                // Redireciona para a página de menu
                return RedirectToAction("Menu", "User");
            }

            // Se houver erros de validação, retorna a view de registro com os erros
            return View(vehicle);
        }
    }
}
