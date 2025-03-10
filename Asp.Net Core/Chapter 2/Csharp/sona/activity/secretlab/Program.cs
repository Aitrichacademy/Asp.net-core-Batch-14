namespace secretlab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Access to a secret lab!");
            Console.WriteLine("Do you have an access card? true or false");
            bool card = bool.Parse(Console.ReadLine().ToLower());
            if(card)
            {
                Console.WriteLine("enter security clearance level ");
                int level = Convert.ToInt32(Console.ReadLine());
                if (level >= 5)
                {
                    Console.WriteLine("entry is allowed");
                }
                else
                {
                    Console.WriteLine("entry is denied");
                }
            }
            else
            {
                Console.WriteLine("are you a scientist : true or false ");
                bool scientist =bool.Parse(Console.ReadLine().ToLower());
                if (scientist)
                {
                    Console.WriteLine("Do you know the secret passcode (true or false)");
                    bool passcode =bool.Parse(Console.ReadLine().ToLower());
                    if (passcode)
                    {

                        Console.WriteLine("entry is allowed");
                    }

                    else
                    {
                        Console.WriteLine("entry is denied");
                    }
                }
                
                else
                {
                    Console.WriteLine("entry is denied");
                }
            }
            Console.ReadLine();
        }
    }
}
