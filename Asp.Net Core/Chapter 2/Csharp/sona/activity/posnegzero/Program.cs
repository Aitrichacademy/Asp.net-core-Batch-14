namespace posnegzero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else if (n < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else
            {
                Console.WriteLine("The number  is equal to zero");
            }
            Console.ReadLine();
        }
    }
}
