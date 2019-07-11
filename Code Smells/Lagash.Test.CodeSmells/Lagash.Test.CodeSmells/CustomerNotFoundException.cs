using System;
namespace Lagash.Test.CodeSmells
{
  public class CustomerNotFoundException : Exception
  {
    public CustomerNotFoundException(string message) : base(message)
    {
    }
  }
}
