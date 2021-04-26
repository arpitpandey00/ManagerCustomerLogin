using System;
using System.Collections.Generic;
using System.Text;
using CustomerProduct.Entities;

namespace CustomerProduct.Databases
{
    class ProductInventoryDBcs
    {
        public static List<Product> ProductList = new List<Product> {
                 new Product{Name="Apple",Price=20,Quantity=100 },
                 new Product{Name="Bottle",Price=200,Quantity=20 },
                 new Product{Name="T-shirt",Price=400,Quantity=50 },
                 new Product{Name="Jens",Price=800,Quantity=60 },
                 new Product{Name="Laptop",Price=50000,Quantity=10 }
        };
       
    }
}
