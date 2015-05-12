    using System.Web.Mvc;
    using StructureMap;
    using StructureMap.Configuration.DSL;
    using StructureMap.Graph;
    using WebApplication3.Filters;
    using WebApplication3.Interfaces;

namespace WebApplication3.DependencyResolution 
{
    public class DefaultRegistry : Registry 
    {
        public DefaultRegistry() 
        {
            Scan(
                scan => {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
					scan.With(new ControllerConvention());
                    
                });
            Policies.SetAllProperties(p => p.OfType<ILogger>());
            //For<IExample>().Use<Example>();
            For<IFilterProvider>().Use(() => new FilterProvider((Container)ObjectFactory.Container));
            //container.RegisterInstance<IFilterProvider>("FilterProvider", new FilterProvider(container));
            //container.RegisterInstance<IActionFilter>("LogActionFilter", new TraceActionFilter());

        }
    }
}