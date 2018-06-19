using System.Web.Mvc;
using System.Web.Routing;
using GameShareManager.Helpers;

namespace GameShareManager
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapLocalizedMvcAttributeRoutes(
                urlPrefix: "{culture}/",
                constraints: new { culture = new CultureConstraint(defaultCulture: CultureHelper.GetDefaultCulture(), pattern: "[a-z]{2}-[A-Z]{2}") }
            );

            routes.MapRoute(
                name: "DefaultWithCulture",
                url: "{culture}/{controller}/{action}/{id}",
                defaults: new { controller = "Loan", action = "Index", id = UrlParameter.Optional },
                constraints: new { culture = new CultureConstraint(defaultCulture: CultureHelper.GetDefaultCulture(), pattern: "[a-z]{2}-[A-Z]{2}") }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { culture = CultureHelper.GetDefaultCulture(), controller = "Loan", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
