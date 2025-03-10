namespace CountNumberofDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the no:");
            int n = Convert.ToInt32(Console.ReadLine());
            int digit = 0;

            while (n > 0)
            {
                int rem = n % 10;
                digit = digit + 1;
                    n = n / 10;
                 
            }
            Console.WriteLine("no of digits in a no is:" + digit);

            Console.ReadLine();
        }
    }
}
