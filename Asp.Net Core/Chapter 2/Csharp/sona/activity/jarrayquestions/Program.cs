namespace jarrayquestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] ja = new int[2][];
            ja[0] = new int[] { 1, 2, 3 };
            ja[1] = new int[] { 2 };
            for (int i = 0; i < ja.Length; i++)
            {
                for (int j = 0; j < ja[i].Length; j++)
                {
                    Console.Write(ja[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("enter the no of rows for jagged array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] jarray = new int[n][];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"enter the no of elements in {i + 1} th row:");
                int m = Convert.ToInt32(Console.ReadLine());
                jarray[i] = new int[m];
                Console.WriteLine($"enter {m} elements:");
                for (int j = 0; j < m; j++)
                {
                    jarray[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The jagged array is:");
            for (int i = 0; i < jarray.Length; i++)
            {
                for (int j = 0; j < jarray[i].Length; j++)
                {
                    Console.Write(jarray[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("The reversed jagged array is:");
            for (int i = 0; i < jarray.Length; i++)
            {
                for (int j = jarray[i].Length-1; j >=0; j--)
                {
                    Console.Write(jarray[i][j]);
                }
                Console.WriteLine();
            }
            int rowsum = 0;
            int temp = 0;
            int row = 0;
            for (int i = 0; i < jarray.Length; i++)
            {
                for (int j = 0; j < jarray[i].Length; j++)
                {
                    rowsum += jarray[i][j];
                }
                Console.WriteLine($"The {i + 1} th row sum is :" + rowsum);


                if (rowsum >= temp)
                {
                    temp = rowsum;
                    row = i + 1;
                }
                rowsum = 0;
            }
            Console.WriteLine("highest sum is: " + temp);
            Console.WriteLine("row in a jagged array that has the highest sum is : " + row);

            //int[][] reversed = new int[jarray.Length][];
            //for (int i = 0; i < jarray.Length; i++)
            //{
            //    for (int j = jarray[i].Length-1,k=0; j >= 0;k++, j--)
            //    {
            //        reversed[i][k] = jarray[i][j];
            //    }

            //}
            //Console.WriteLine("The reversed jagged array is:");
            //for (int i = 0; i < jarray.Length; i++)
            //{
            //    for (int j = 0; j < reversed[i].Length; j++)
            //    {
            //        Console.Write(reversed[i][j]);
            //    }
            //    Console.WriteLine();
            //}
            int max = 0;

            for (int i = 0; i < jarray.Length; i++)
            {

                max = jarray[i].Length;

                Console.WriteLine($"The {i + 1} th row's maximum elements are: " + max);

            }





            Console.ReadLine();
        }
    }
}
