using System;
using System.Collections.Generic;
using CustomerProduct.Authentication;

namespace CustomerProduct.Data
{
    public class MainMenu
    {
        public void Menu()
        {
            AuthenticateCustomer authenticateCustomer = new AuthenticateCustomer();
            bool exitmenu = false;
            while(exitmenu!=true)
            {
                Console.Clear();
            Console.WriteLine("------Welcome customer------\n");
            Console.WriteLine("a. Login Customer");
            Console.WriteLine("b. New Customer(SignUp):");
                Console.WriteLine("c. go back");
                switch (Console.ReadLine().ToLower())
                {
                    case "a":
                        Console.Clear();
                        authenticateCustomer.ExistingCustomer();
                        exitmenu = true;
                        break;
                    case "b":
                        Console.Clear();
                        authenticateCustomer.AddingNewCustomer();
                        exitmenu = true;
                        break;
                    case "c":
                        exitmenu = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid Input..... Try Again.....");
                        Console.ReadKey();
                        break;
                }
            }
         }




     
    }
}
