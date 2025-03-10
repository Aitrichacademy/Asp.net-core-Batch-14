namespace SumofArrayElementsForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 2, 4, 2, 3 };
            Console.WriteLine("Enter the size of the array:");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[size];
            Console.WriteLine("enter " + size + " numbers:");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            Console.WriteLine("The sum of array elements is:" + sum);
        }
    }
}
