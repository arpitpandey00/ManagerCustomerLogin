using System;
using System.Collections.Generic;
using System.Text;
using CustomerProduct.Databases;
using CustomerProduct.OperationOnEntities;
using CustomerProduct.Entities;
using System.Linq;
using CustomerProduct.Authentication;

namespace CustomerProduct.Validation
{
    public class ManageQuantity
    {
        public void QuantityAfterPurchase()
        {
            
            foreach(CartProduct product in OperationOfCustomer.cartItem)
            {
                Product inventoryProduct = ProductInventoryDBcs.ProductList.Find(s => s.Id == product.Id);
                inventoryProduct.Quantity = inventoryProduct.Quantity - product.Quantity;
            }
            //Authenticate authenticate = new Authenticate();
            //Console.ReadKey();
            //authenticate.Login();
        }
    }
}
