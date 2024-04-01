using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DestinoCerto.Models;

namespace DestinoCerto.Controllers
{
    public class DriverController : Controller
    {
        public static List<Driver> driverList = new List<Driver>();

        // GET: Driver/Register
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Driver driver)
        {
            // Verifica se já existe um motorista com o mesmo CPF
            if (driverList.Any(d => d.Cpf == driver.Cpf))
            {
                ModelState.AddModelError("Cpf", "Já existe um motorista cadastrado com este CPF.");
            }

            if (ModelState.IsValid)
            {

                driverList.Add(driver);

                return RedirectToAction("Menu", "User");
            }

            return View(driver);
        }
    }
}
