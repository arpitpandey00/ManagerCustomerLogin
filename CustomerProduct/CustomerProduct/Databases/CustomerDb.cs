using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerProduct.Databases
{
    public class CustomerDb
    {
          public static IDictionary<string, string> customerdb = new Dictionary<string, string>
            {  {"login","login"} };

        public void AddingCustomerInDatabase(string username, string password)
        {
              customerdb.Add(username, password);
        }
    }
       
    }
