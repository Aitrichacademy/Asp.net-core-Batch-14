namespace swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After swapping");
            Console.WriteLine("First number is:" + num1);
            Console.WriteLine("Second number is:" + num2);
            Console.ReadLine();
        }
    }
}
