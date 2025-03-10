namespace enumOrderStatus
{
    enum OrderStatus
    {
        Pending = 1, Processing = 2, Shipped = 3, Delivered = 4, Cancelled = 5
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number:");
            
            if (int.TryParse(Console.ReadLine(),out int input) && Enum.IsDefined(typeof(OrderStatus),input))
            {
                OrderStatus status=(OrderStatus)input;
                Console.WriteLine($"status is :{status}");
            }
            else
            {
                Console.WriteLine("enter valid no..");
            }

        }
    }
}
