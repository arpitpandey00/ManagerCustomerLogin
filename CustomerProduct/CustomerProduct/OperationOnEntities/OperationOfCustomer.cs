using System;
using System.Collections.Generic;
using System.Text;
using CustomerProduct.Entities;
using CustomerProduct.Data;
using System.Linq;
using CustomerProduct.Authentication;
using CustomerProduct.Databases;

namespace CustomerProduct.OperationOnEntities
{
    
    public class OperationOfCustomer
    {
        public static List<Product> cartItem = new List<Product>();    

        public void FindProductForCustomer(int productId,int quantity)
        {
            Product findproduct = ProductInventoryDBcs.ProductList.Single(search => search.Id == productId);
            findproduct.Quantity = quantity;
            cartItem.Add(findproduct);
            Console.WriteLine("\nProduct Added\n");
        }
        public int TotalPriceToPay()
        {
            int totalprice = 0;
            foreach(Product cartproduct in cartItem)
            {
                totalprice += cartproduct.Price * cartproduct.Quantity;
            }
            return totalprice;
        }
        public void GenrateBill()
        {
            foreach(Product displaycartproduct in cartItem)
            {
                Console.WriteLine($"Name :{displaycartproduct.Name}");
                Console.WriteLine($"Quantity :{displaycartproduct.Quantity}");
                Console.WriteLine($"Price(each) :{displaycartproduct.Price}");
            }
        }
        public void DisplayProducts()
        {
            if (ProductInventoryDBcs.ProductList.Count < 1)
            {
                Console.WriteLine("No items Avaliable:");
                Console.WriteLine("Press Enter For Main Menu");
                Console.ReadKey();
                Authenticate authenticate = new Authenticate();
                authenticate.Login();
            }
            else
            {
                foreach (Product product in ProductInventoryDBcs.ProductList)
                {
                    Console.WriteLine(product.ToString());
                }
            }
        }
        public void AddProductsToCart()
        {
            var exitcustomer = "";
            OperationOfCustomer operationOfCustomer = new OperationOfCustomer();
            do
            {
                Console.WriteLine("\nEnter Id Of Product To Add In Cart:\n");
                int IdNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Quatity :");
                int Quantity = Convert.ToInt32(Console.ReadLine());
                operationOfCustomer.FindProductForCustomer(IdNumber, Quantity);
                Console.WriteLine("\nTo Add More Press (y): To Buy Press (n): ");
                exitcustomer = Console.ReadLine().ToLower();
            } while (exitcustomer != "n");
            return ;
        }
        public void purchase()
        {
            OperationOfCustomer operationOfCustomer = new OperationOfCustomer();
            Console.Clear();
            int TotalPrice = 0;
            Console.WriteLine("---Your Bill---\n");
            operationOfCustomer.GenrateBill();
            TotalPrice = operationOfCustomer.TotalPriceToPay();
            Console.WriteLine($"Total price to pay :{TotalPrice}\n");
            Console.WriteLine("\nVisit Again\n press enter.....");
        }

        public void DisplayMyCart()
        {
            Console.Clear();
            if (OperationOfCustomer.cartItem.Count < 1)
            {
                Console.WriteLine("No items Avaliable:");
                Console.WriteLine("Press Enter To Go Back");
            }
            else
            {

            Console.WriteLine("Items In Cart :\n");

            foreach(Product product in OperationOfCustomer.cartItem)
            {
                Console.WriteLine(product.ToString());
            }
            }
            Console.ReadKey();
        }
        public void DropCart()
        { 
                OperationOfCustomer.cartItem.Clear();
            Console.WriteLine("See You Soon");
            Console.ReadKey();
        }
    }
}
