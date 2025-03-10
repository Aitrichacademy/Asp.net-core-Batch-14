namespace avg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Third number: ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Fourth number: ");
            int n4 = Convert.ToInt32(Console.ReadLine());

            int avg = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine("The average of "+n1+","+n2 + "," + n3 + "," + n4 + " " + "is: "+avg);

        }
    }
}
