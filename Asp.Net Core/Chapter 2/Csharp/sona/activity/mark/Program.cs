namespace mark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n =Convert.ToInt32(Console.ReadLine());
            if (n >=90)
            {
                Console.WriteLine("A grade");
            }
            else if (n >= 80)
            {
                Console.WriteLine("B grade");

            }
            else if (n >= 60)
            {
                Console.WriteLine("C grade");
            }
            else
            {
                Console.WriteLine("Failed!");
            }

            Console.Read();
        }
    }
}
