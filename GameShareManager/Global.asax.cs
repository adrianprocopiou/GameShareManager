using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using GameShareManager.Application.AutoMapper;
using GameShareManager.Helpers;
using GameShareManager.IoC;
using LightInject;

namespace GameShareManager
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalFilters.Filters.Add(new GlobalHandlerError());
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            LightInjectConfig.ServiceContainer.RegisterControllers(typeof(MvcApplication).Assembly);
            LightInjectConfig.ServiceContainer.EnableMvc();
            AutoMapperConfig.RegisterMapping();
        }
    }
}
