using Lagash.Test.Application;
using Lagash.Test.Infrastructure.JSON;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace Lagash.Test.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<ICustomerUseCase, CustomerUseCase>();
            container.RegisterType<IServiceJson, ServiceJSON>();            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}