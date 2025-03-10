namespace SpaceMissionControlPanel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("space mission control panel ");
            Console.WriteLine("launch , abort , status ,self-destruct , reboot  ");

            Console.WriteLine("select command code :");
            string code = Console.ReadLine().ToLower();

            switch (code)
            {
                case "launch":
                    Console.WriteLine("Initiating launch sequence... 🚀");
                    break;
                case "abort":
                    Console.WriteLine("Mission aborted! Returning to standby mode. ❌");
                    break;
                case "status":
                    Console.WriteLine("All systems operational. ✅");
                    break;
                case "self-destruct":
                    Console.WriteLine("WARNING! Self-destruct sequence initiated! 💥");
                    break;
                case "reboot":
                    Console.WriteLine("Rebooting all systems... Please wait. 🔄");
                    break;
                default:
                    Console.WriteLine("Invalid command. Please enter a valid operation!");
                    break;
            }
        }
    }
}
