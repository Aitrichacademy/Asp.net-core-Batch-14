namespace enumPaymentMethod
{
    enum PaymentMethod
    {
        Cash=1, CreditCard, DebitCard, UPI, NetBanking
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Payment methods are:");
            foreach (PaymentMethod method in Enum.GetValues(typeof(PaymentMethod)))
            {
                Console.WriteLine($"{(int)method}.{method}");
            }
            Console.WriteLine("please select payment method(enter a number):");
            if (int.TryParse(Console.ReadLine(),out int input)&& Enum.IsDefined(typeof(PaymentMethod),input) )
            {
                PaymentMethod method = (PaymentMethod)input;
                Console.WriteLine($"you selected {method} method");
            }
            else
            {
                Console.WriteLine("please enter valid no shown above");
            }

            Console.ReadLine();
        }
    }
}
