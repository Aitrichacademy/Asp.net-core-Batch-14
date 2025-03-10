namespace SmartVendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smart Vending Machine ");
            Console.WriteLine("1. Coke , 2. Chips , 3. Chocolate ,4. Water , 5. Juice  ");

            Console.WriteLine("select product code:");
            int code = Convert.ToInt32(Console.ReadLine());

            switch (code)
            {
                case 1:
                    Console.WriteLine("Coke 🥤 - $1.50");
                    break;
                case 2:
                    Console.WriteLine("Chips 🍟 - $1.00");
                    break;
                case 3:
                    Console.WriteLine("Chocolate 🍫 - $2.00");
                    break;
                case 4:
                    Console.WriteLine("Water 💧 - $1.00");
                    break;
                case 5:
                    Console.WriteLine("Juice 🍊 - $1.75");
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again!");
                    break;
            }
        }
    }
}
