using System.Collections.Generic;

namespace Lagash.Test.Infrastructure.JSON
{
    public interface IServiceJson
    {
        IEnumerable<dynamic> GetCustomers();
        void AddCustomer<T>(T customer);
    }
}
