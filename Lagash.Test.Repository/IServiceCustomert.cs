namespace Lagash.Test.Repository
{
    using Lagash.Test.Models;
    using System.Collections.Generic;

    public interface IServiceCustomer
    {
        IEnumerable<Customer> GetCustomers();

        void SaveCustomer(Customer customer);  
    }
}
