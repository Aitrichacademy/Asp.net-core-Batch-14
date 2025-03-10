namespace fibonaccidowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int a = 1;
            int b = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);
            
            do
            {
                int sum = a + b;
                Console.WriteLine(sum);
                a = b;
                b = sum;
                n++;
            }
            while (n<11);

            Console.ReadLine();
        }
    }
}
