namespace nestedif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine("The number is positive and ");
                if (n % 2 == 0)
                {
                    Console.WriteLine("The number is even");
                }
                else
                {
                    Console.WriteLine("The number is odd");
                }
            }
            else if (n < 0)
            {
                Console.WriteLine("The number is negative and ");
                if (n % 2 == 0)
                {
                    Console.WriteLine("The number is even");
                }
                else
                {
                    Console.WriteLine("The number is odd");
                }
            }
            else
            {
                Console.WriteLine("The number  is equal to zero");
            }
            Console.ReadLine();
        }
    }
}
