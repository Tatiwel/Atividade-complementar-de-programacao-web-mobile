using System;
using System.Collections.Generic;
using System.Web.Mvc;
using DestinoCerto.Models;

namespace DestinoCerto.Controllers
{
    public class TransportController : Controller
    {
        // Lista para armazenar os transportes cadastrados
        public static List<Transport> transportList = new List<Transport>();

        // GET: Transport/Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: Transport/Register
        [HttpPost]
        public ActionResult Register(Transport transport)
        {
            if (ModelState.IsValid)
            {
                // Adiciona o transporte à lista (simulando a inserção no banco de dados)
                transportList.Add(transport);

                // Redireciona para o relatório financeiro
                return RedirectToAction("Menu", "User");
            }

            // Se houver erros de validação, retorna a view de registro com os erros
            return View(transport);
        }
    }
}
