using CustomerProduct.Authentication;

namespace CustomerProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Authenticate authentication = new Authenticate();
            authentication.Login();

        }
    }
}
