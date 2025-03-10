namespace enumforloop
{
    enum Week
    {
        Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Array days = Enum.GetValues(typeof(Week));
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days.GetValue(i)); 
            }
        }
    }
}
