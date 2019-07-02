using System.Collections.Generic;

namespace Lagash.Test.Infrastructure.JSON
{
    public interface ICustomerRepository
    {
        IEnumerable<dynamic> GetCustomers();
        void AddCustomer<T>(T customer);
    }
}
