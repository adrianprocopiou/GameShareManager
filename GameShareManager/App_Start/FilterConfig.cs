using System.Web;
using System.Web.Mvc;
using GameShareManager.Helpers;

namespace GameShareManager
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new CultureFilter(defaultCulture:"pt-BR"));
            filters.Add(new HandleErrorAttribute());
        }
    }
}
