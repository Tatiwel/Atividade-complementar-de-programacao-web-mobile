using System;
using System.Collections.Generic;
using System.Web.Mvc;
using DestinoCerto.Models;

namespace DestinoCerto.Controllers
{
    public class VehicleController : Controller
    {
        private static List<Vehicle> vehicleList = new List<Vehicle>();
        // verifica se existe um motorista com o CPF informado
        private static bool DriverExists(string cpf)
        {
            return DriverController.driverList.Exists(d => d.Cpf == cpf);
        }

        // GET: Vehicle/Register
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Unregister()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Vehicle vehicle)
        {
            // Verifica se já existe um veículo com a mesma placa
            if (vehicleList.Exists(v => v.Placa == vehicle.Placa))
            {
                ModelState.AddModelError("Placa", "Já existe um veículo cadastrado com esta placa.");
            }

            // Verifica se o motorista informado existe
            if (!DriverExists(vehicle.CpfMotorista))
            {
                ModelState.AddModelError("CpfMotorista", "Motorista não encontrado.");
            }

            if (ModelState.IsValid)
            {
                vehicleList.Add(vehicle);

                return RedirectToAction("Menu", "User");
            }

            return View(vehicle);
        }

        [HttpPost]
        public ActionResult Unregister(Vehicle vehicle)
        {
            // Verifica se o veículo informado existe
            if (!vehicleList.Exists(v => v.Placa == vehicle.Placa))
            {
                ModelState.AddModelError("Placa", "Veículo não encontrado.");
            }

            if (ModelState.IsValid)
            {
                vehicleList.RemoveAll(v => v.Placa == vehicle.Placa);

                return RedirectToAction("Menu", "User");
            }

            return View(vehicle);
        }

        [HttpPost]
        public ActionResult List()
        {
            return View(vehicleList);
        }

        [HttpPost]
        public ActionResult ListByDriver(string cpf)
        {
            return View(vehicleList.FindAll(v => v.CpfMotorista == cpf));
        }

        [HttpPost]
        public ActionResult ListByType(string type)
        {
            return View(vehicleList.FindAll(v => v.TipoTransporte == type));
        }

        [HttpPost]
        public ActionResult ListByPassengerCapacity(int min, int max)
        {
            return View(vehicleList.FindAll(v => v.CapacidadePassageiros >= min && v.CapacidadePassageiros <= max));
        }
    }
}
