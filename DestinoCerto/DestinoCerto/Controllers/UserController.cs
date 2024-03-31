using System.Collections.Generic;
using System.Web.Mvc;
using DestinoCerto.Models;

namespace DestinoCerto.Controllers
{
    public class UserController : Controller
    {
        // Simulação de um banco de dados em memória
        private static List<User> userList = new List<User>();

        // GET: User/Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: User/Register
        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                // Adiciona o usuário à lista (simulando a inserção no banco de dados)
                userList.Add(user);

                // Redireciona para a página de menu
                return RedirectToAction("Menu", "User");
            }

            // Se houver erros de validação, retorna a view de registro com os erros
            return View(user);
        }

        // GET: User/Menu
        public ActionResult Menu()
        {
            // Retorna a view de menu com a lista de usuários
            return View(userList);
        }
    }
}
