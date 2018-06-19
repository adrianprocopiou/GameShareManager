using System.Web.Mvc;
using NLog;

namespace GameShareManager.Helpers
{
    public class GlobalHandlerError : IExceptionFilter
    {
        private static Logger _logger = LogManager.GetLogger("LoggerException");


        public void OnException(ExceptionContext filterContext)
        {
            _logger.Error(filterContext.Exception, filterContext.Controller.ControllerContext.RequestContext.RouteData.Values["action"].ToString);
        }
    }
}