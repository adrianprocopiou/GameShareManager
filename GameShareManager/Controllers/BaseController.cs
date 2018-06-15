using System;
using System.Threading;
using System.Web.Mvc;

namespace GameShareManager.Controllers
{
    public class BaseController : Controller
    {
        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            var cultureName = CultureHelper.GetImplementedCulture(RouteData.Values["culture"].ToString());

            RouteData.Values["culture"] = cultureName;

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cultureName);
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            return base.BeginExecuteCore(callback, state);
        }
    }
}