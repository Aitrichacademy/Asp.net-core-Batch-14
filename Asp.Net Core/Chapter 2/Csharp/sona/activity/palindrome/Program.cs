namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            int reverse = 0;

            while (temp > 0)
            {
                int rem = temp % 10;
                reverse = reverse * 10 + rem;
                temp = temp / 10;
            }
            if (n == reverse)
            {
                Console.WriteLine("The given no is palindrome");
            }
            else
            {
                Console.WriteLine("The given no is not a palindrome!");
            }
            Console.ReadLine();
        }
    }
}
