namespace enumTrafficLight
{
    enum TrafficLight
    {
        Red,Green,Yellow
    }
    internal class Program
    {
        static string Action(TrafficLight color)
        {
            if (TrafficLight.Red == color)
            {
                return "stop";
            }
            else if (TrafficLight.Green == color)
            {
                return "GO";
            }
            else
            {
                return "Go slow";
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the color:");
            string input = Console.ReadLine();

            if (Enum.TryParse(input,true,out TrafficLight color))
            {
                Console.WriteLine($"{color} action : {Action(color)}");
            }
            else
            {
                Console.WriteLine("Invalid colour..");
            }
        }
    }
}
