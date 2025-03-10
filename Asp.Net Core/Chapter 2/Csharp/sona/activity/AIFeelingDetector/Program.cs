namespace AIFeelingDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given a feeling :( \"happy\", \"sad\", \"angry\", \"bored\", \"excited\", \"tired\"), the AI suggests an activity");
            string feeling = Console.ReadLine().ToLower();

            if (feeling== "happy")
            {
                Console.WriteLine("Go out and celebrate! 🎉");
            }
            else if (feeling=="sad")
            {
                Console.WriteLine("Watch a comforting movie. 🍿");
            }
            else if (feeling == "angry")
            {
                Console.WriteLine("Try meditation or deep breathing. 🧘");
            }
            else if (feeling == "bored")
            {
                Console.WriteLine("Read a book or try a new hobby. 📚");
            }
            else if (feeling == "excited")
            {
                Console.WriteLine("Share the good news with friends! 🎊");
            }
            else if (feeling == "tired")
            {
                Console.WriteLine("Take a nap or rest. 😴");
            }
            else
            {
                Console.WriteLine("Mood not recognized. Try expressing yourself more clearly!");
            }


                Console.Read();
        }
    }
}
