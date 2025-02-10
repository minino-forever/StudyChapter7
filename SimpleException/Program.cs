namespace SimpleException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Simple Exception Example ******\n");

            Console.WriteLine(" Creating a car and stepping on it!\n");

            Car myCar = new Car("Zippe", 20);

            myCar.CrankTunes(true);
            try
            {

            for (int i = 0; i < 10; i++)
            {
                myCar.Accelerate(10);
            }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n ****Error!****");
                Console.WriteLine($"Method: {ex.TargetSite}");
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Sourse: {ex.Source}");
            }

            Console.WriteLine("\n ****** Out of exception logic *****");
        }
    }
}
