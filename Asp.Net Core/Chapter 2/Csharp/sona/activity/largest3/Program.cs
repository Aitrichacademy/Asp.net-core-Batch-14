namespace largest3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            int n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2 && n1>n3)
            {
                Console.WriteLine(n1 + " is greater than " + n2 +" and " +n3);
            }
            else if(n2 > n1 && n2 > n3)
            {
                Console.WriteLine(n2 + " is greater than " +  n1 + " and " + n3);
            }
            else
            {
                Console.WriteLine(n3 + " is greater than " + n1 + " and " + n2);
            }
                Console.ReadLine();
        }
    }
}
