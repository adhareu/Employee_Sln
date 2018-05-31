using Asset.Service;
using Asset.WebAPI.DI;
using Microsoft.Practices.Unity;
using System.Web.Http;



namespace Asset.WebAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents(HttpConfiguration config)
        {
            UnityContainer container = new UnityContainer();
        
          
            container.RegisterType<IDepartmentService, DepartmentService>();
          
            config.DependencyResolver = new UnityResolver(container);
        }
    }
}