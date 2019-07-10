using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using Newtonsoft.Json;

namespace Lagash.Test.Infrastructure.JSON
{
    public class CustomersInMemory : ICustomerRepository
    {        
        public void AddCustomer<T>(T customer)
        {
               
        }

        public IEnumerable<dynamic> GetCustomers()
        {
            return new List<dynamic>()
            {
                new { Name="Horacio", Surname = "Brizuela", Age = 30},
                new { Name="Pepe", Surname = "Brizuela", Age = 27}
            };
        }        
    }
}
