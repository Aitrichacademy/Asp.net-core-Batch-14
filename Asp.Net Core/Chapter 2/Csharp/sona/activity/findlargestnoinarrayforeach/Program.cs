namespace findlargestnoinarrayforeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of the array:");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[size];
            Console.WriteLine("enter " + size + " numbers");

            for (int i = 0; i < size; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int largest = numbers[0];
            foreach (int n in numbers)
            {
                if (n>largest)
                {
                    largest = n;
                }
            }
            Console.WriteLine("The largest number in the array is:" + largest);


        }
    }
}
