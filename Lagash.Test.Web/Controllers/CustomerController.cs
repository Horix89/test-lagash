namespace Lagash.Test.Web.Areas.Clients.Controllers
{
    using Lagash.Test.Repository;
    using Models;
    using System.Collections.Generic;
    using System.Web.Http;

    [RoutePrefix("api")]
    public class CustomerController : ApiController
    {        
        public CustomerController(IServiceCustomer serviceClient)
        {         
        }
                      
        [Route("customers")]
        public IEnumerable<Customer> GetCustomers()
        {
            return null;
        }
    }
}
