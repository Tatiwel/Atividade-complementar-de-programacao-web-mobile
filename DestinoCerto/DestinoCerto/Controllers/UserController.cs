using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DestinoCerto.Models;

namespace DestinoCerto.Controllers
{
    public class UserController : Controller
    {
        private static List<User> users = new List<User>();

        // Página de login
        public ActionResult Login()
        {
            return View();
        }

        // Ação de autenticação de login
        [HttpPost]
        public ActionResult Login(string email, string senha)
        {
            var user = users.FirstOrDefault(u => u.Email == email && u.Senha == senha);
            if (user != null)
            {
                // Login bem-sucedido, redirecionar para a página inicial
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Caso contrário, exibir mensagem de erro
                ViewBag.ErrorMessage = "Usuário ou senha inválidos";
                return View();
            }
        }

        // Página de cadastro de usuário
        public ActionResult Register()
        {
            return View();
        }

        // Ação de cadastro de usuário
        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                users.Add(user);
                return RedirectToAction("Login");
            }
            return View(user);
        }
    }
}
