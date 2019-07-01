namespace Lagash.Test.Web.Areas.Clients.Controllers
{
    using Lagash.Test.Application;
    using Models;
    using System.Collections.Generic;
    using System.Web.Http;

    [RoutePrefix("api")]
    public class CustomerController : ApiController
    {        
        public CustomerController(ICustomerUseCase customerUseCase)
        {     
        }
                      
        [Route("customers")]
        public IEnumerable<dynamic> GetCustomers()
        {
            return null;
        }
    }
}
