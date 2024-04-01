using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DestinoCerto.Models;

namespace DestinoCerto.Controllers
{
    public class UserController : Controller
    {
        private static List<User> userList = new List<User>();

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            if (userList.Any(u => u.Cpf == user.Cpf))
            {
                ModelState.AddModelError("Cpf", "Já existe um usuário cadastrado com este CPF.");
            }

            if (ModelState.IsValid)
            {
                userList.Add(user);

                return RedirectToAction("Menu", "User");
            }
            return View(user);
        }
        public ActionResult Menu()
        {
            return View(userList);
        }
    }
}
