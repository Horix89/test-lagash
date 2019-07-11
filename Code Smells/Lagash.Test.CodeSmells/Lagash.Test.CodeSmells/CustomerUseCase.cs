using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace Lagash.Test.CodeSmells
{
  public class CustomerUseCase
  {
    private readonly ILogger logger;
    public void GetCustomerInformation(string name,int age)
    {
      try
      {
        //obtain the customers
        List<Customer> customers = GetCustomers();

        logger.LogDebug("We have the customers", customers);

        //select the customer
        var customer = customers.FirstOrDefault(m => m.Name == name);
        logger.LogDebug("customer founded", customer);

        //i 'm not sure if this code will be deleted or not
        //if (customer.Surname == "Pepe")
        //{
        //  Console.WriteLine("That is the Customer");
        //}


        if (customer.Age != age)
          throw new CustomerNotFoundException("Customer not founded");


      }
      catch
      {

      }
      Console.WriteLine("Hello World!");
    }


    static List<Customer> GetCustomers()
    {
      return new List<Customer>();

    }
  }
}
