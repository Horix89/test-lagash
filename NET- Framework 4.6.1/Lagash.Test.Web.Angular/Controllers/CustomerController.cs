using Lagash.Test.Application;
using Lagash.Test.Models;
using Lagash.Test.ViewModels.Client;
using System.Collections.Generic;
using System.Web.Http;

namespace Lagash.Test.Web.Angular.Controllers
{
    public class CustomerController : ApiController
    {

        public CustomerController(ICustomerUseCase customerUseCase)
        {
        }
        
        public IHttpActionResult Create(CustomerViewModel customer)
        {
            return null;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return null;
        }
    }
}
