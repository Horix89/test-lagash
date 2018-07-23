namespace Lagash.Test.Impl
{
    using Repository;
    using System.Collections.Generic;
    using Models;

    public class CustomerRepository : IServiceCustomer
    {
        public CustomerRepository()
        {
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return null;
        }

        public void SaveCustomer(Customer customer)
        {    
        }
    }
}
