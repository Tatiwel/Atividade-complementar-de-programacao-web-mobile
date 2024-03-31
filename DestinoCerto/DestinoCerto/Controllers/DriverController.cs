using System;
using System.Collections.Generic;
using System.Web.Mvc;
using DestinoCerto.Models;

namespace DestinoCerto.Controllers
{
    public class DriverController : Controller
    {
        // Lista para armazenar os motoristas cadastrados
        private static List<Driver> driverList = new List<Driver>();

        // GET: Driver/Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: Driver/Register
        [HttpPost]
        public ActionResult Register(Driver driver)
        {
            if (ModelState.IsValid)
            {
                // Adiciona o motorista à lista (simulando a inserção no banco de dados)
                driverList.Add(driver);

                // Redireciona para a página de menu
                return RedirectToAction("Menu", "User");
            }

            // Se houver erros de validação, retorna a view de registro com os erros
            return View(driver);
        }
    }
}
