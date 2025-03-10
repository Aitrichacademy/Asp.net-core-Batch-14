namespace enumSeverityLevel
{
    enum SeverityLevel
    {
        Low, Medium, High, Critical
    }
    internal class Program
    {
        static string Message(SeverityLevel level)
        {
            if (SeverityLevel.Low==level)
            {
                return "No immediate action required. Monitor the situation.";
            }
            else if (SeverityLevel.Medium==level)
            {
                return "Some risk is present. Take precautionary steps.";
            }
            else if (SeverityLevel.High==level)
            {
                return "Significant risk detected! Take immediate action.";
            }
            else
            {
                return "Emergency! Immediate intervention is required!";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter Severity Level:");
            string input = Console.ReadLine();
            if (Enum.TryParse(input,true,out SeverityLevel level))
            {
                Console.WriteLine($" {Message(level)}");
            }
            else
            {
                Console.WriteLine("Please enter valid Severity Level");
            }
        }
    }
}
