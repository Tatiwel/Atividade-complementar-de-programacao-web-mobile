using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DestinoCerto.Models;

namespace DestinoCerto.Controllers
{
    public class HomeController : Controller
    {
        // Alterado para retornar a view Index.cshtml
        public ActionResult Index()
        {
            return View("Index");
        }


    }
}
