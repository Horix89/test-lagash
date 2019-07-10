using System.Collections.Generic;
using Lagash.Test.Infrastructure.JSON;
using Lagash.Test.Models;

namespace Lagash.Test.Application
{
    public class CustomerUseCase : ICustomerUseCase
    {        
        public CustomerUseCase(ICustomerRepository customerRepository)
        {            
        }

        public IEnumerable<dynamic> GetCustomers()
        {
            return null;
        }
    }
}
