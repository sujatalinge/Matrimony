using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDUsingEFDBFirstApproach.Common
{
    public class CustomFilterAttribute : ActionFilterAttribute,
        IExceptionFilter
    {
        FileLogger log = new FileLogger();
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string controllerName = 
                filterContext.RouteData.Values["controller"].ToString();
            string actionName =
               filterContext.RouteData.Values["action"].ToString();
            string  currentTime = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            string logText = string.Format($"{currentTime} \n{controllerName} ->{actionName}" +
                $" -> OnActionExecuting");

            log.LogToFile(logText);
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            string controllerName =
                filterContext.RouteData.Values["controller"].ToString();
            string actionName =
               filterContext.RouteData.Values["action"].ToString();
            string currentTime = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            string logText = string.Format($"{currentTime} \n{controllerName} ->{actionName}" +
                $" -> OnActionExecuted");

            log.LogToFile(logText);
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            string controllerName =
                           filterContext.RouteData.Values["controller"].ToString();
            string actionName =
               filterContext.RouteData.Values["action"].ToString();
            string currentTime = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            string logText = string.Format($"{currentTime} \n{controllerName} ->{actionName}" +
                $" -> OnResultExecuting");

            log.LogToFile(logText);
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            string controllerName =
                 filterContext.RouteData.Values["controller"].ToString();
            string actionName =
               filterContext.RouteData.Values["action"].ToString();
            string currentTime = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            string logText = string.Format($"{currentTime} \n{controllerName} ->{actionName}" +
                $" -> OnResultExecuted");

            log.LogToFile(logText);
        }
        public void OnException(ExceptionContext filterContext)
        {
            string controllerName =
                filterContext.RouteData.Values["controller"].ToString();
            string actionName =
               filterContext.RouteData.Values["action"].ToString();
            string currentTime = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            string logText = string.Format($"{currentTime} \n{controllerName} ->{actionName}" +
                $" -> OnException");

            log.LogToFile(logText);
        }
    }
}