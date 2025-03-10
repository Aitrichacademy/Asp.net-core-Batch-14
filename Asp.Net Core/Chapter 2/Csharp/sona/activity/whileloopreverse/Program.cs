namespace whileloopreverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the no:");
            int n = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;

            while (n > 0)
            {
                int reminder = n % 10;
                reverse = reverse * 10 + reminder;
                n = n / 10;
             }
            Console.WriteLine("Reverse is:"+reverse);
        }
    }
}
