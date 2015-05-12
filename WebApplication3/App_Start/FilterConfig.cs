using System.Web.Mvc;
using WebApplication3.Filters;

namespace WebApplication3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(DependencyResolver.Current.GetService<LogActionFilter>());
        }
    }
}
