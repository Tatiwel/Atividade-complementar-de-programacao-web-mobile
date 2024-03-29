using System.Web.Mvc;

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
