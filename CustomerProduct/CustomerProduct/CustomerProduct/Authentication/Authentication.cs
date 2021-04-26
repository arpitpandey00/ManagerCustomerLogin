using System;
using System.Collections.Generic;
using CustomerProduct.Data;

namespace CustomerProduct.Authentication
{
    public class Authenticate
    {
        public void Login()
        {
            MainMenu customerMainMenu = new MainMenu();
        InventoryManagerData inventorymanager = new InventoryManagerData();
            bool ExitApp = false;
            while (ExitApp != true)
            {
                Console.Clear();
                Console.WriteLine("--------Welcome TO E-Commerce--------\n");
                Console.WriteLine("a. Login/SignUp Customer\n");
                Console.WriteLine("b. Manager Login\n");
                Console.WriteLine("c. Exit App");
                switch (Console.ReadLine().ToLower())
                {
                    case "a":
                        customerMainMenu.Menu();
                        ExitApp = true;
                        break;
                    case "b":
                        AutheniticateManager autheniticateManager = new AutheniticateManager();
                        autheniticateManager.ExistingManager();
                        ExitApp = true;
                        break;
                    case "c":
                        Console.WriteLine("Exiting......");
                        ExitApp = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Input....... Try Again");
                        Console.ReadKey();
                        break;
                }
            }

        }
    }
}