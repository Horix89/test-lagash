namespace Lagash.Test.Web.Angular
{
    using Impl;
    using Microsoft.Practices.Unity;
    using Repository;
    using System.Web.Http;
    using Unity.WebApi;
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IServiceCustomer, CustomerRepository>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}