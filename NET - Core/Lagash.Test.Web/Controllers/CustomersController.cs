using Lagash.Test.Application;
using Microsoft.AspNetCore.Mvc;

namespace Lagash.Test.Web.Controllers
{
  [Route("api/[controller]")]
    public class CustomersController : Controller
    {        
        public CustomersController(ICustomerUseCase customerUseCase)
        {            
        }
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            return null;
        }              
    }
}
