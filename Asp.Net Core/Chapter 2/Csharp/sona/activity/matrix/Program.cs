namespace matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of rows or cols m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the no of cols n: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[m, m];
            Console.WriteLine("Enter the elements : ");
            for (int i = 0; i < m; i++) 
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i,j]= Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The matrix is: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum += matrix[i, j];
                }
            }
            Console.WriteLine("Sum of all elements in matrix: "+sum);
            int rowsum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0;  j < m; j++)
                {
                    rowsum += matrix[i, j];
                }
                Console.WriteLine("The " + i + " th row sum is: " +rowsum);
                rowsum = 0;
            }

            int colsum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    colsum += matrix[j, i];
                }
                Console.WriteLine("The " + i + " th column sum is: " + colsum);
                colsum = 0;
            }
            int max= matrix[0, 0];
            int min = matrix[0, 0];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if(max<matrix[i, j])
                    {
                        max = matrix[i, j];
                    }
                    if (min > matrix[i, j])
                    {
                        min = matrix[i, j];
                    }

                }
            }
            Console.WriteLine("The largest no is : " + max);
            Console.WriteLine("The smallest no is : " + min);
            
            Console.WriteLine("The transpose of a matrix is: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[j,i]);
                }
                Console.WriteLine();
            }











            Console.ReadLine();





        }
    }
}
