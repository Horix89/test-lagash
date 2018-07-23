
namespace Lagash.Test.Web.Angular.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;
    using Repository;
    using ViewModels.Client;
    using Models;     

    public class CustomerController : ApiController
    {

        public CustomerController(IServiceCustomer serviceClient)
        {
        }
        
        public IHttpActionResult Create(CustomerViewModel clent)
        {
            return null;
        }

        public IEnumerable<Customer> GetClients()
        {
            return null;
        }
    }
}
