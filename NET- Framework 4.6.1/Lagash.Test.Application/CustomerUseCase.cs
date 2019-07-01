using System.Collections.Generic;
using Lagash.Test.Infrastructure.JSON;
using Lagash.Test.Models;

namespace Lagash.Test.Application
{
    public class CustomerUseCase : ICustomerUseCase
    {        
        public CustomerUseCase(IServiceJson serviceJson)
        {            
        }

        public IEnumerable<dynamic> GetCustomers()
        {
            return null;
        }
    }
}
