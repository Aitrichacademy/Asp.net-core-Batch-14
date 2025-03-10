using System.Diagnostics;

namespace enumWeatherCondition
{
    enum WeatherCondition
    {
        Sunny=1, Rainy, Cloudy, Windy, Snowy
    }
    internal class Program
    {
        static void Message(WeatherCondition weather)
        {
            switch (weather)
            {
                case WeatherCondition.Sunny:
                    Console.WriteLine("It's a bright and sunny day! Enjoy the sunshine.");
                    break;
                case WeatherCondition.Rainy:
                    Console.WriteLine("It's raining outside. Don't forget your umbrella!");
                    break;
                case WeatherCondition.Cloudy:
                    Console.WriteLine("It's cloudy today. Might rain later, stay prepared!");
                    break;
                case WeatherCondition.Windy:
                    Console.WriteLine(" It's quite windy. Hold on to your hats!");
                    break;
                case WeatherCondition.Snowy:
                    Console.WriteLine(" It's snowing! Time for some hot chocolate.");
                    break;
                default:
                    Console.WriteLine("no weather");
                    break;



            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Weather Condition");
            foreach (WeatherCondition item in Enum.GetValues(typeof(WeatherCondition)))
            {
                Console.WriteLine($"{(int)item}. {item}");
            }
            Console.WriteLine("enter the weather:");
            string input = Console.ReadLine();

            if (Enum.TryParse(input,true,out WeatherCondition weather))
            {
                Console.WriteLine($"Today's weather : {weather}");
                Message(weather);
            }
            else
            {
                Console.WriteLine("enter valid input");
            }
           
        }
    }
}
