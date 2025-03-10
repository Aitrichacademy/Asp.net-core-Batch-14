namespace multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(n+"*"+i+"="+(n*i));
            }
            Console.ReadLine();
        }
    }
}
