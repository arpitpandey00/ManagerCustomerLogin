using System;
using System.Collections.Generic;
using System.Text;
using CustomerProduct.OperationOnEntities;
using CustomerProduct.Authentication;

namespace CustomerProduct.Data
{
    public class InventoryManagerData
    {
            OperationOfManager manageroperation = new OperationOfManager();
        public void ManageProductsDatabase()
        {
            bool exitProductDatabase = false;
            while(exitProductDatabase !=true)
            {
                Console.Clear();
                Console.WriteLine("------Welcome Manager------");
                Console.WriteLine("a. Add New Product");
                Console.WriteLine("b. Update Product");
                Console.WriteLine("c. Logout Manager");
                switch(Console.ReadLine().ToLower())
                {
                    case "a":
                        Console.Clear();
                        manageroperation.AddNewProduct();
                        break;
                    case "b":
                        this.UpdateProductDB();
                        break;
                    case "c":
                        exitProductDatabase = true;
                        Authenticate authenticate = new Authenticate();
                        authenticate.Login();
                        //where to go
                        break;
                    default:
                        Console.WriteLine("Invalid Operatoin.... Try Again");
                        Console.ReadKey();
                        break;
                }

            }
        }
        public void UpdateProductDB()
        {
            bool exitUpdate = false;
            while(exitUpdate!=true)
            {
                Console.WriteLine("b.1->(a) Update Product Name");
                Console.WriteLine("b.2->(b) Update Product Quantity");
                Console.WriteLine("b.3->(c) Update Product Price");
                Console.WriteLine("b.4->(d) Delete Product ");
                Console.WriteLine("(e) go back to manager dashboard");
                switch (Console.ReadLine().ToLower())
                {
                    case "a":
                        Console.Clear();
                        manageroperation.UpdateProductName();
                        break;
                    case "b":
                        Console.Clear();
                        manageroperation.UpdateProductQuanity();
                        break;
                    case "c":
                        Console.Clear();
                        manageroperation.UpdateProductPrice();
                        break;
                    case "d":
                        Console.Clear();
                        manageroperation.UpdateDeleteProduct();
                        break;
                    case "e": 
                        exitUpdate = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Operatoin.... Try Again");
                        Console.ReadKey();
                        break;
                }
            }

        }
    }
}
