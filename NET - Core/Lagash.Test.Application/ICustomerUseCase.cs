using Lagash.Test.Models;
using System.Collections.Generic;

namespace Lagash.Test.Application
{
    public interface ICustomerUseCase
    {
        IEnumerable<dynamic> GetCustomers();
    }
}
