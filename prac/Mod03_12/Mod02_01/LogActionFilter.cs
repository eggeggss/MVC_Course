using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Mod02_01
{

    
    public class LogActionFilter:ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Log("OnActionExecuted", filterContext.RouteData);


            //System.Diagnostics.Debug.WriteLine("OnActionExecuted");
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Log("OnActionExecuting", filterContext.RouteData);

            // System.Diagnostics.Debug.WriteLine("OnActionExecuting");
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Log("OnResultExecuted", filterContext.RouteData);

            //System.Diagnostics.Debug.WriteLine("OnResultExecuted");
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Log("OnResultExecuting", filterContext.RouteData);

            //System.Diagnostics.Debug.WriteLine("OnResultExecuting");
        }

        private void Log(string mehtodName,RouteData routeDate)
        {
            var controllerName = routeDate.Values["controller"];
            var actionName = routeDate.Values["action"];
            var message = $"methodname:{mehtodName} controller:{controllerName},action:{actionName}";
        }

    }
}