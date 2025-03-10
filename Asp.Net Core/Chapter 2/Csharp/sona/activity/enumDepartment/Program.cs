namespace enumDepartment
{
    internal class Program
    {
        enum Department
        {
            HR = 101, IT = 102, Finance = 103, Marketing = 104
        }
        static void Main(string[] args)
        {
            Console.WriteLine("eneter the no:");
            if (int.TryParse(Console.ReadLine(), out int input) && Enum.IsDefined(typeof(Department), input))
            {
                Department dept = (Department)input;
                Console.WriteLine($"{dept}");
            }
            else
            {
                Console.WriteLine("please enter valid no");
            }
        }
    }
}
