using System.Web.Mvc;
using WebApplication3.Interfaces;

namespace WebApplication3.Filters
{
    public class LogActionFilter : ActionFilterAttribute
    {
        public ILogger Logger { get; set; }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Logger.Log(filterContext.ActionDescriptor.ActionName + " executed.");
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Logger.Log(filterContext.ActionDescriptor.ActionName + " executing.");
        }
    }
}