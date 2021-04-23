using System;
using System.Collections.Generic;
using System.Text;
using CustomerProduct.Authentication;
using CustomerProduct.Data;
using CustomerProduct.Entities;
using CustomerProduct.OperationOnEntities;

namespace CustomerProduct.Data
{
    public class CustomersData
    {

        public void ManageCustomerOperation()
        {
            OperationOfCustomer customeroperation = new OperationOfCustomer();
            bool exitCustomer = false;
            while (exitCustomer != true)
            {
                Console.WriteLine("------Welcome TO Menu------\n");
                Console.WriteLine("a. Display all Products");
                Console.WriteLine("b. Add Products To Cart");
                Console.WriteLine("c. Show My Cart");
                Console.WriteLine("d. Purchase Item");
                Console.WriteLine("e. Do Not Want To Buy");
                Console.WriteLine("f. logout customer");
                switch (Console.ReadLine().ToLower())
                {
                    case "a":
                        Console.Clear();
                        customeroperation.DisplayProducts();
                        break;
                    case "b":
                        
                        customeroperation.AddProductsToCart();
                        break;
                    case "c":
                        
                        customeroperation.DisplayMyCart();
                        break;
                    case "d":
                        
                        customeroperation.purchase();
                        Console.ReadKey();
                        exitCustomer = true;
                        break;
                    case "e":
                        customeroperation.DropCart();
                        exitCustomer = true;
                        Authenticate authenticate1 = new Authenticate();
                        authenticate1.Login();
                        break;
                    case "f":
                        exitCustomer = true;
                        Authenticate authenticate = new Authenticate();
                        customeroperation.DropCart();
                        authenticate.Login();
                        break;
                    default:
                        Console.WriteLine("Invalid Operation..... Try Again.....\n");
                        Console.ReadKey();
                        break;
                }
            }

        }
}
}
