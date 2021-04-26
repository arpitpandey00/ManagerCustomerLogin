using System;
using System.Collections.Generic;
using System.Text;
using CustomerProduct.Entities;
using CustomerProduct.Data;
using System.Linq;
using CustomerProduct.Authentication;
using CustomerProduct.Databases;
using CustomerProduct.Validation;

namespace CustomerProduct.OperationOnEntities
{
    
    public class OperationOfCustomer
    {
        public static List<CartProduct> cartItem = new List<CartProduct>();    

        public void FindProductForCustomer(int productId,int quantity)
          {
            Product findproduct = ProductInventoryDBcs.ProductList.Single(search => search.Id == productId);
            int quantityofinventory = findproduct.Quantity;
            cartItem.Add(new CartProduct { Id = findproduct.Id, Name = findproduct.Name, Quantity = quantity, Price = findproduct.Price });
            Console.WriteLine("\nProduct Added\n");
        }
        public int TotalPriceToPay()
        {
            int totalprice = 0;
            foreach(CartProduct cartproduct in cartItem)
            {
                totalprice += cartproduct.Price * cartproduct.Quantity;
            }
            return totalprice;
        }
        public void GenrateBill()
        {
            foreach(CartProduct displaycartproduct in cartItem)
            {
                Console.WriteLine($"Name :{displaycartproduct.Name}");
                Console.WriteLine($"Quantity :{displaycartproduct.Quantity}");
                Console.WriteLine($"Price(each) :{displaycartproduct.Price}\n");
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
            QuantityAvaliable quantityAvaliable = new QuantityAvaliable();
            var exitcustomer = "";
            do
            {
                Console.WriteLine("\nEnter Id Of Product To Add In Cart:\n");
                ValidateId validateId = new ValidateId();
                int IdNumber = validateId.IsIdExist();
                Console.WriteLine("Enter Quatity :");
                int Quantity = quantityAvaliable.IsQuantityAvaliable(IdNumber);
                this.FindProductForCustomer(IdNumber, Quantity);
                Console.WriteLine("\nTo Add More Press Any key Else Press (n): ");
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
            ManageQuantity manageQuantity = new ManageQuantity();
            manageQuantity.QuantityAfterPurchase();
            Console.ReadKey();
            
        }

        public void DisplayMyCart()
        {
            Console.Clear();
            if (cartItem.Count < 1)
            {
                Console.WriteLine("No items Avaliable:");
                Console.WriteLine("Press Enter To Go Back");
            }
            else
            {

            Console.WriteLine("Items In Cart :\n");

            foreach(CartProduct product in cartItem)
            {
                Console.WriteLine(product.ToString());
            }
            }
            Console.ReadKey();
        }
        public void DropCart()
        {

            cartItem.Clear();
            Console.WriteLine("See You Soon");
            Console.ReadKey();
        }
    }
}
