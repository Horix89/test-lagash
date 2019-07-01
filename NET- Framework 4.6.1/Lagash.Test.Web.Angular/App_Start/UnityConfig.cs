namespace Lagash.Test.Web.Angular
{
    using Lagash.Test.Application;
    using Microsoft.Practices.Unity;
    using System.Web.Http;
    using Unity.WebApi;
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<ICustomerUseCase, CustomerUseCase>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}