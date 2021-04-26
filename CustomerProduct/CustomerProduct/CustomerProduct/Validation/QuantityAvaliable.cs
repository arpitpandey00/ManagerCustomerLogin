using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomerProduct.Databases;
using CustomerProduct.Entities;
using CustomerProduct.OperationOnEntities;

namespace CustomerProduct.Validation
{
    public class QuantityAvaliable
    {
        public int IsQuantityAvaliable(int id)
        {
            int quantity = Convert.ToInt32(Console.ReadLine());
            Product findProduct = ProductInventoryDBcs.ProductList.Single(search => search.Id == id);
            if(findProduct.Quantity<quantity)
            {
                Console.WriteLine("\nRequired quantity is not avaliable... Try Again....\n");
                Console.ReadKey();
                OperationOfCustomer operationOfCustomer = new OperationOfCustomer();
                operationOfCustomer.AddProductsToCart();
                
            }
            else if (findProduct.Quantity == 0)
            {
                Console.WriteLine("\nProduct is out of stock... Add Another Product....\n");
                Console.ReadKey();
                OperationOfCustomer operationOfCustomer = new OperationOfCustomer();
                operationOfCustomer.AddProductsToCart();

            }
            return quantity;
            
        }
    }
}
