using Lagash.Test.Impl;
using Lagash.Test.Repository;
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

            container.RegisterType<IServiceCustomer, CustomerRepository>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}