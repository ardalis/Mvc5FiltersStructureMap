using System.Web.Mvc;
using StructureMap;

namespace WebApplication3.Filters
{
    public class FilterProvider : FilterAttributeFilterProvider
    {
        private readonly Container _container;

        public FilterProvider(Container container)
        {
            _container = container;
        }

        public override System.Collections.Generic.IEnumerable<Filter> GetFilters(ControllerContext controllerContext, ActionDescriptor actionDescriptor)
        {
            var filters = base.GetFilters(controllerContext, actionDescriptor);
            foreach (var filter in filters)
            {
                _container.BuildUp(filter);
                yield return filter;
            }
        }
    }
}