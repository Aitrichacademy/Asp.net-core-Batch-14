namespace largest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine(n1 + " is greater than " + n2);
            }
            else
            {
                Console.WriteLine(n2 + " is greater than " + n1);
            }
            Console.ReadLine();
        }
    }
}
