using System;

namespace single_dimensional_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Find the Maximum and Minimum Element
            //int[] numbers = new int[4] { 1,56,9,4};
            //int max = numbers[0];
            //int min = numbers[0];
            //foreach (int n in numbers)
            //{
            //    if (n>max)
            //    {
            //        max = n;
            //    }
            //    if (n < min)
            //    {
            //        min = n;
            //    }
            //}
            //Console.WriteLine("Maximum:" + max);
            //Console.WriteLine("Minimum:" + min);
            //Console.ReadLine();

            //Reverse an Array
            //int[] numbers = new int[3] { 1, 2, 3 };
            //int[] reversed = new int[3];
            //for (int i = 2,j=0; i >=0; j++,i--)
            //{
            //    reversed[j] = numbers[i];
            //}
            //Console.WriteLine("The reversed array is:");
            //for (int k = 0; k < 3; k++)
            //{
            //    Console.Write( reversed[k]);
            //}
            //Console.ReadLine();

            //Sum and Average of Array Elements
            //int[] numbers = new int[3] { 1, 2, 3 };
            //int sum = 0;
            //for (int i = 0; i < 3; i++)
            //{
            //    sum += numbers[i];   
            //}
            //int avg = sum / 3;
            //Console.WriteLine("The sum of array is:"+" "+sum+" avg is: "+avg);
            //Console.ReadLine();

            //Count Occurrences of an Element
            //Console.WriteLine("enter the size of the array: ");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = new int[size];
            //Console.WriteLine("enter " + size + " elements:");
            //for (int i = 0; i < size; i++)
            //{
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("enter the element to find how many times a given number appears : ");
            //int k = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //for (int j = 0; j < size; j++)
            //{
            //    if(numbers[j] ==k)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count +" times a given number "+k+" appears  ");
            //Console.ReadLine();

            //Sort an Array (Ascending and Descending)
            Console.WriteLine("enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            Console.WriteLine("enter " + size + " elements:");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            selectionsort(numbers,true);
            Console.WriteLine("Ascending: "+string.Join(" ",numbers));
            selectionsort(numbers, false);
            Console.WriteLine("Descending :" + string.Join(" ", numbers));
        
        
        }
        static void selectionsort(int[] numbers,bool ascending)
        {
            int n = numbers.Length;
            
            for (int i = 0; i < n - 1; i++)
            {
               int  index = i;
                for (int j = i + 1; j < n; j++)
                {
                    if ((ascending && numbers[j] < numbers[index]) || (!ascending && numbers[j] > numbers[index]))
                    {
                        index = j;
                    }

                }

                int temp = numbers[index];
                numbers[index] = numbers[i];
                numbers[i] = temp;
            }


        }


    }
}
