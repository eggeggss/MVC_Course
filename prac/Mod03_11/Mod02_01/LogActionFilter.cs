using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mod02_01
{
    public class LogActionFilter:ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            System.Diagnostics.Debug.WriteLine("OnActionExecuted");
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            System.Diagnostics.Debug.WriteLine("OnActionExecuting");
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            System.Diagnostics.Debug.WriteLine("OnResultExecuted");
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            System.Diagnostics.Debug.WriteLine("OnResultExecuting");
        }
    }
}