namespace leapyear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year:");
            int year = Convert.ToInt32(Console.ReadLine());

            if((year%4==0 && year%100!=0) || (year % 400 == 0))
            {
                Console.WriteLine("The year is leap year");
            }
            else
            {
                Console.WriteLine("Year is not leap year");
            }
        }
    }
}
