namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first no:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second no:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select the operator : + or - or / or * ");
            char operation = Convert.ToChar(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Console.WriteLine("The sum is:"+ (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("The result is:" + (num1 + num2));
                    break;
                case '/':
                    Console.WriteLine("The division is:" + (num1 + num2));
                    break;
                case '*':
                    Console.WriteLine("The multiplication is:" + (num1 + num2));
                    break;
                default:
                    Console.WriteLine(operation);
                    break;
            }
        }
    }
}
