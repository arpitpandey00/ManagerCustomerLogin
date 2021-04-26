using System;
using System.Collections.Generic;
using System.Text;
using CustomerProduct.Authentication;
using CustomerProduct.Databases;
using CustomerProduct.Data;

namespace CustomerProduct.Authentication
{
     public class AuthenticateCustomer
    {
        public void ExistingCustomer()
        {

            try
            {
            Console.Clear();
            Console.WriteLine("---------Login Please--------");
            Console.WriteLine("Enter Id :");
            string id = Console.ReadLine();
            Console.WriteLine("Enter Password :");
            string password = string.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;



                if (key == ConsoleKey.Backspace && password.Length > 0)
                {
                    Console.Write("\b \b");
                    password = password[0..^1];
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    Console.Write("*");
                    password += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);
                CustomerDb.customerdb.ContainsKey(id);
                if(CustomerDb.customerdb[id]==password)
                {
                    Console.WriteLine("\n<----LOGIN SUCCESSFUL---->");
                    Console.ReadKey();
                    CustomersData customer = new CustomersData();
                    customer.ManageCustomerOperation();
                }
            }
            catch(Exception)
            {
                Console.WriteLine("\nInvalid Id/Password....Try Again");
                Console.ReadKey();
                MainMenu mainMenu = new MainMenu();
                mainMenu.Menu();
            }
           
        }
        public void AddingNewCustomer()
        {
            try
            {

            Console.Clear();
            Console.WriteLine("----- Adding New Customer -----\n");
            Console.WriteLine("\nEnter Full Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter User Name : ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password :");
            string password = Console.ReadLine();
            CustomerDb.customerdb.Add(username, password);
            Console.WriteLine($"Hello {name} \nSignUp Successful\nYour Username Is : {username}\nYour Password Is : {password}\nKEEP IT CONFIDENTAIL..");
            Console.ReadKey();
                Authenticate authenticate = new Authenticate();
                authenticate.Login();
            }
            catch(Exception)
            {
                Console.WriteLine("User id Already exist... Try Again");
                Console.ReadKey();
                this.AddingNewCustomer();
            }

        }
    }
}
