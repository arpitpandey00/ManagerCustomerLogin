using System;
using System.Collections.Generic;
using System.Text;
using CustomerProduct.Data;
using CustomerProduct.Entities;
using System.Linq;
using CustomerProduct.Databases;
using CustomerProduct.Validation;

namespace CustomerProduct.OperationOnEntities
{
    public class OperationOfManager
    {
        public void AddNewProduct()
        {
            Console.Clear();
            Console.WriteLine("Enter Product Details :\n");
            ValidName validName = new ValidName();
            Console.WriteLine("Enter Product Name : ");
            string name = validName.IsProductNameValid();
            Console.WriteLine("\nEnter Product Quantity : ");
            ValidQuantity validQuantity = new ValidQuantity();
            int quantity = validQuantity.QuantityValidating();
            Console.WriteLine("\nEnter Selling Price : ");
            ValidPrice validPrice = new ValidPrice();
            int sellingprice = validPrice.PriceValidating();
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
            try
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
            catch(Exception)
            {
                Console.WriteLine("Product with this name is not avaliable.... try again \n");
                Console.WriteLine("press y to try again or press n");
                if(Console.ReadLine().ToLower()=="y")
                {
                this.UpdateProductName();
                }
                else
                {
                    InventoryManagerData inventoryManagerData = new InventoryManagerData();
                    inventoryManagerData.ManageProductsDatabase();
                }
            }
        }
        public void UpdateProductQuanity()
        {
            try
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
            catch(Exception)
            {
                Console.WriteLine("Product with this Id is not avaliable.... try again \n");
                this.UpdateProductQuanity();
            }

        }
        public void UpdateProductPrice()
        {
            try
            { 

            Console.WriteLine("Enter Product Id To Find : ");
            int IdToFind = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Price To Update : ");
            int PriceToUpdate = Convert.ToInt32(Console.ReadLine());
            Product findproduct = ProductInventoryDBcs.ProductList.Single(single => IdToFind == single.Id);
            findproduct.Price = PriceToUpdate;
            Console.WriteLine("Updated Successfully");
            Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Product with this Id is not avaliable.... try again \n");
                this.UpdateProductPrice();
            }

        }
        public void UpdateDeleteProduct()
        {
            try
            {

            
            Console.WriteLine("Enter Product Id To Delete : ");
            int IdToFind = Convert.ToInt32(Console.ReadLine());
            Product findproduct = ProductInventoryDBcs.ProductList.Single(single => IdToFind == single.Id);
            ProductInventoryDBcs.ProductList.Remove(findproduct);
            Console.WriteLine("Removed Successfully");
            Console.ReadKey();
        }
             catch (Exception)
            {
                Console.WriteLine("Product with this Id is not avaliable.... try again \n");
                this.UpdateDeleteProduct();
            }
        }
     }
 }
