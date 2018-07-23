namespace Lagash.Test.DataAccess.JSON
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.IO;
    using Newtonsoft.Json;

    public class ServiceJSON<T>
    {
        public IEnumerable<T> GetCustomers()
        {
            return JsonConvert.DeserializeObject<IEnumerable<T>>(File.ReadAllText(path));
        }

        public void AddCustomer(T customer)
        {
            File.WriteAllText("", JsonConvert.SerializeObject(customer));            
        }

        private static string path
        {
            get { return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ConfigurationManager.AppSettings["pathJson"]); }
        }

        private static string pathFile
        {
            get { return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ConfigurationManager.AppSettings["pathFile"]); }
        }
    }
}
