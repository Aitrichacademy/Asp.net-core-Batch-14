namespace arraytypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //single dimensional array
            //string[] person1 = new string[4];
            //person1[0] = "a";
            //person1[1] = "b";
            //person1[2] = "c";
            //person1[3] = "d";
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine(person1[i]);
            //}
            //Console.ReadLine();

            //multidimensional array
            //string[,] person2 = new string[2,2];
            //person2[0,0] = "a";
            //person2[0, 1] = "b";
            //person2[1, 0] = "c";
            //person2[1, 1] = "d";
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write(person2[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            //jaggedarray
            int[][] jaggedarray = new int[4][];
            jaggedarray[0] = new int[] { 1, 2, 3 };
            jaggedarray[1] = new int[] { 4, 5 };
            jaggedarray[2] = new int[] { 5, 6, 8, 9 };
            jaggedarray[3] = new int[] { 2 };
            for (int i = 0; i < jaggedarray.Length; i++)
            {
                for (int j = 0; j < jaggedarray[i].Length; j++)
                {
                    Console.Write(jaggedarray[i][j]);
                }
                Console.WriteLine();
            }



        }
    }
}
