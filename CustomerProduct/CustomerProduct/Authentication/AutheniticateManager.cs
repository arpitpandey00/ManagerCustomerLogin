using System;
using System.Collections.Generic;
using System.Text;
using CustomerProduct.Data;

namespace CustomerProduct.Authentication
{
    public class AutheniticateManager
    {
        public static IDictionary<string, string> Managerdb = new Dictionary<string, string>
            {  {"Arpit","qwerty"} };
        public void ExistingManager()
        {
            try
            {
            Console.Clear();
            Console.WriteLine("-----Login Please------\n");
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
                Managerdb.ContainsKey(id);
                if (Managerdb[id] == password)
                {
                    Console.WriteLine("\n<----LOGIN SUCCESSFUL---->");
                    Console.ReadKey();
                    InventoryManagerData inventoryManagerData = new InventoryManagerData();
                    inventoryManagerData.ManageProductsDatabase();
                }

            }
            catch (Exception)
            {
                Console.WriteLine("\nInvalid Id/Password....Try Again");
                Console.ReadKey();
                this.ExistingManager();
            }
           
        }
    }
}
