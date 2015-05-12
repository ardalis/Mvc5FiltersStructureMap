using WebApplication3.App_Start;
using WebActivatorEx;
using System.Web.Mvc;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using WebApplication3.DependencyResolution;
using StructureMap;

[assembly: PreApplicationStartMethod(typeof(StructuremapMvc), "Start")]
[assembly: ApplicationShutdownMethod(typeof(StructuremapMvc), "End")]

namespace WebApplication3.App_Start {
    
	public static class StructuremapMvc {
        public static StructureMapDependencyScope StructureMapDependencyScope { get; set; }
		
		public static void End() {
            StructureMapDependencyScope.Dispose();
        }
		
        public static void Start() {
            IContainer container = IoC.Initialize();
            StructureMapDependencyScope = new StructureMapDependencyScope(container);
            DependencyResolver.SetResolver(StructureMapDependencyScope);
            DynamicModuleUtility.RegisterModule(typeof(StructureMapScopeModule));
        }
    }
}