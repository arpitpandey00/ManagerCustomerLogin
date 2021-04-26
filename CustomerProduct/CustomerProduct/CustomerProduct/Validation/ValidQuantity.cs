using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerProduct.Validation
{
    public class ValidQuantity
    {
        public int QuantityValidating()
        {
            int Productquantity = 0;
            try
            {
                Productquantity = Convert.ToInt32(Console.ReadLine());
                if (Productquantity <= 0)
                {
                    Console.WriteLine("Quantity should be greter than 0");
                    QuantityValidating();

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Quantity should be a number and greater than 0");
                Console.WriteLine("\nEnter Quantity Again : ");
                QuantityValidating();
            }
            return Productquantity;
        }
    }
}
