using CustomerProduct.Authentication;

namespace CustomerProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Authenticate authentication = new Authenticate();
            authentication.Login();

        }
    }
}
