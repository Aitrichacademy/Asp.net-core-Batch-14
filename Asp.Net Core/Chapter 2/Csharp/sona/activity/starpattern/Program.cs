namespace starpattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int k = 1; k <=i; k++)
                {
                    Console.Write("* ");
                    
                }
                Console.WriteLine();
            }
            
        }
    }
}
