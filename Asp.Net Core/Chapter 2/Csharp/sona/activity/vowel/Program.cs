namespace vowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the character:");
            char alphabet = Convert.ToChar(Console.ReadLine());

            //if (alphabet=='a'|| alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u' || alphabet == 'A' || alphabet == 'E' || alphabet == 'I' || alphabet == 'O' || alphabet == 'U')
            if("aeiouAEIOU".Contains(alphabet))
            {
                Console.WriteLine("The alphabet is vowel");
            }
            else
            {
                Console.WriteLine("The alphabet is consonant");
            }
        }
    }
}
