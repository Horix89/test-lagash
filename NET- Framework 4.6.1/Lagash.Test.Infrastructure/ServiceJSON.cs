using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using Newtonsoft.Json;

namespace Lagash.Test.Infrastructure.JSON
{
    public class ServiceJSON : IServiceJson
    {        
        public void AddCustomer<T>(T customer)
        {
            File.WriteAllText("", JsonConvert.SerializeObject(customer));            
        }

        public IEnumerable<dynamic> GetCustomers()
        {
            return JsonConvert.DeserializeObject<IEnumerable<dynamic>>(File.ReadAllText(path));
        }

        private static string path
        {
            get { return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ConfigurationManager.AppSettings["pathJson"]); }
        }
    }
}
