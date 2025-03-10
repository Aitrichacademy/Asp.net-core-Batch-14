using System;

namespace norow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a digit: ");
            int digit = Convert.ToInt32(Console.ReadLine());
           
                    Console.WriteLine("{0} {0} {0} {0}" ,digit);
               
                    Console.WriteLine("{0}{0}{0}{0}", digit);
                    Console.WriteLine("{0} {0} {0} {0}", digit);

                    Console.WriteLine("{0}{0}{0}{0}", digit);



            Console.ReadLine();
        }
    }
}
