namespace enummonth
{
    enum Months
    {
        january=1,february,march,april,may,june,july,august,september,october,november,december
    }
    internal class Program
    {
        static int GetMonthNo(Months month)
        {
            return (int)month;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the month: ");
            String input = Console.ReadLine();

            if (Enum.TryParse(input,true,out Months month))
            {
                Console.WriteLine($"The month is :{month} and month number is:{GetMonthNo(month)}");
            }
            else
            {
                Console.WriteLine("Invalid month");
            }
            Console.ReadLine();
        }
    }
}
