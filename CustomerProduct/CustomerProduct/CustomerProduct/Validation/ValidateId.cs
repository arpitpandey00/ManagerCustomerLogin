using System;
using System.Collections.Generic;
using System.Text;
using CustomerProduct.Entities;
using CustomerProduct.Databases;
using System.Linq;

namespace CustomerProduct.Validation
{
    public class ValidateId
    {
        public int IsIdExist()
        {
            int ischeck = Convert.ToInt32(Console.ReadLine());
            try
            {
                Product findproduct = ProductInventoryDBcs.ProductList.Single(s => s.Id == ischeck);
                if(findproduct.Id<1)
                {
                    Console.WriteLine("Product With This Id Do Not Exit In Inventory\n");
                    Console.WriteLine("Add Avaliable Product To Cart ..\n");
                    Console.WriteLine("Enter Id Again");
                    Console.ReadKey();
                    IsIdExist();
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Product With This Id Do Not Exit In Inventory\n");
                Console.WriteLine("Add Avaliable Product To Cart ..\n");
                Console.WriteLine("Enter Id Again");
                Console.ReadKey();
                IsIdExist();
            }
            return ischeck;
        }
    }
}
