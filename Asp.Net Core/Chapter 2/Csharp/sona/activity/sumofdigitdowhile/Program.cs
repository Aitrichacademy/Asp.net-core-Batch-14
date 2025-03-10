namespace sumofdigitdowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            do
            {
                sum += n % 10;
                n = n / 10;

            }
            while (n>0);
            Console.WriteLine("Sum of digits is:" + sum);

            Console.ReadLine();
        }
    }
}
