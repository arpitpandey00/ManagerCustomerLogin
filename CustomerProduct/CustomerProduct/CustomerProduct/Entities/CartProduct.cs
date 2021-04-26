using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerProduct.Entities
{
    public class CartProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public override string ToString()
        {
            return $"Id :{Id}\nName : {Name}\nPrice : {Price}\nQuantity : {Quantity}";
        }
    }
}
