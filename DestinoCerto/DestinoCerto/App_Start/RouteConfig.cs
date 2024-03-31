using Microsoft.AspNet.FriendlyUrls;
using System.Web.Mvc;
using System.Web.Routing;

namespace DestinoCerto
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Rota padrão
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            // Rota para a página de registro de usuário
            routes.MapRoute(
                 name: "Register",
                 url: "User/Register",
                 defaults: new { controller = "User", action = "Register" }
           );

        }
    }
}
