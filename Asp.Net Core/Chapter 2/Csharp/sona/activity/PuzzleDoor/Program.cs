namespace PuzzleDoor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("do you solved the puzzle (true or false)");
            bool solved = bool.Parse(Console.ReadLine().ToLower());
            if (solved)
            {
                Console.WriteLine("ancient temple door opened");
            }
            else 
            {
                Console.WriteLine("Do you possess the golden amulet (true or false)");
                bool amulet = bool.Parse(Console.ReadLine().ToLower());
                Console.WriteLine("Do you have a companion who knows the puzzle solution (true or false)");
                bool solution = bool.Parse(Console.ReadLine().ToLower());

                if (amulet || solution)
                {
                    Console.WriteLine("ancient temple door opened");
                }
                else
                {
                    Console.WriteLine("Do they are a direct descendant of the temple's creators (true or false)");
                    bool isdescendant = bool.Parse(Console.ReadLine().ToLower());
                    if (isdescendant)
                    {
                        Console.WriteLine("ancient temple door opened");
                    }
                    else
                    {
                        Console.WriteLine("the door remains locked");
                    }
                }

            }
        }
    }
}
