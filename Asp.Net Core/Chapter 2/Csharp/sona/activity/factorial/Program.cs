namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a no:");
            int n = Convert.ToInt32(Console.ReadLine());
            int fact = 1;

            for(int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial is:" + fact);
            Console.ReadLine();

        }
    }
}
