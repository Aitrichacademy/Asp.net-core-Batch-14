namespace vote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the age:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Person is Eligible to Vote");
            }
            else
            {
                Console.WriteLine("Person is not Eligible to Vote");
            }

            Console.ReadLine();
        }
    }
}
