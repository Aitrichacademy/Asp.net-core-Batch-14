namespace spacerescue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("distress signal (true or false):");
            bool signal = bool.Parse(Console.ReadLine().ToLower());
            if (signal)
            {
                Console.WriteLine("The spaceship will attempt a rescue ..");
            }
            else
            {
                Console.WriteLine("is astronaut  on a habitable planet (true or false)");
                bool astronaut = bool.Parse(Console.ReadLine().ToLower());
                if (astronaut)
                {
                    Console.WriteLine("is planet  within reachable distance (true or false)");
                    bool distance = bool.Parse(Console.ReadLine().ToLower());
                    if (distance)
                    {
                        Console.WriteLine("The spaceship will attempt a rescue ..");
                    }
                    else
                    {
                        Console.WriteLine("The spaceship will not attempt a rescue ..");
                    }
                }
                else
                {
                    Console.WriteLine("The spaceship will not attempt a rescue ..");
                }
            }

            Console.ReadLine();
        }
    }
}
