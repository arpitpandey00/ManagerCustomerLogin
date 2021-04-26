using System;
using System.Collections.Generic;
using System.Text;
using CustomerProduct.Entities;
using CustomerProduct.Databases;

namespace CustomerProduct.Validation
{
    public class ValidName
    {
        public string IsProductNameValid()
        {
            String ProductName = "";
            try
            {
                ProductName = Console.ReadLine();
                if (ProductName.Length <= 0)
                {
                    Console.WriteLine("Name length should be greter than 0");
                    IsProductNameValid();

                }
                bool isProductExist = false;
                foreach(Product product in ProductInventoryDBcs.ProductList)
                {
                    if(product.Name.ToLower()==ProductName.ToLower())
                    {
                        isProductExist = true;
                    }
                }
                if(isProductExist==true)
                {
                    Console.WriteLine("Product Already Exit In Inventory\n");
                    Console.WriteLine("Add again..");
                    Console.ReadKey();
                    IsProductNameValid();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Name  and Length should be greater than 0");
                Console.WriteLine("\nEnter Name Again : ");
                IsProductNameValid();
            }
            return ProductName;
        }
    }
    
}
