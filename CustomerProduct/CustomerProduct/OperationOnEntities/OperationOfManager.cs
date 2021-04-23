using System;
using System.Collections.Generic;
using System.Text;
using CustomerProduct.Data;
using CustomerProduct.Entities;
using System.Linq;
using CustomerProduct.Databases;

namespace CustomerProduct.OperationOnEntities
{
    public class OperationOfManager
    {
        public void AddNewProduct()
        {
            Console.Clear();
            Console.WriteLine("Enter Product Details :\n");
            Console.WriteLine("Enter Product Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("\nEnter Product Quantity : ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter Selling Price : ");
            int sellingprice = Convert.ToInt32(Console.ReadLine());
            ProductInventoryDBcs.ProductList.Add(new Product
            {
                Name = name,
                Price = sellingprice,
                Quantity = quantity
           }) ;
            Console.WriteLine("Product Added succesfully\n");
            Console.ReadKey();
        }
            
        public void UpdateProductName()
        {
            Console.WriteLine("Enter Product Name To Find : ");
            string NameToFind = Console.ReadLine();
            Console.WriteLine("Enter Product Name To Update : ");
            string NameToUpdate = Console.ReadLine();
            Product findproduct = ProductInventoryDBcs.ProductList.Single(single => NameToFind == single.Name);
            findproduct.Name = NameToUpdate;
            Console.WriteLine("Updated Successfully");
            Console.ReadKey();
        }
        public void UpdateProductQuanity()
        {
            Console.WriteLine("Enter Product Id To Find : ");
            int IdToFind = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Quantity To Update : ");
            int QuantityToUpdate = Convert.ToInt32(Console.ReadLine());
            Product findproduct = ProductInventoryDBcs.ProductList.Single(single => IdToFind == single.Id);
            findproduct.Quantity = QuantityToUpdate;
            Console.WriteLine("Updated Successfully");
            Console.ReadKey();

        }
        public void  UpdateProductPrice()
        {
            Console.WriteLine("Enter Product Id To Find : ");
            int IdToFind = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Price To Update : ");
            int PriceToUpdate = Convert.ToInt32(Console.ReadLine());
            Product findproduct = ProductInventoryDBcs.ProductList.Single(single => IdToFind == single.Id);
            findproduct.Price =PriceToUpdate;
            Console.WriteLine("Updated Successfully");
            Console.ReadKey();

        }
        public void UpdateDeleteProduct()
        {
            Console.WriteLine("Enter Product Id To Delete : ");
            int IdToFind = Convert.ToInt32(Console.ReadLine());
            Product findproduct = ProductInventoryDBcs.ProductList.Single(single => IdToFind == single.Id);
            ProductInventoryDBcs.ProductList.Remove(findproduct);
            Console.WriteLine("Removed Successfully");
            Console.ReadKey();
        }
     }
    
}
