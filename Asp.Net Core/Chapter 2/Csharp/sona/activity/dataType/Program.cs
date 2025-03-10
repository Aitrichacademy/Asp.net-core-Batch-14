namespace dataType
{
    class Student
    {
        public string Name;
        public int Age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = 25;
            //double n2 =1.2;
            //string name = "sona";
            //Console.WriteLine("integer value:"+n);
            //Console.WriteLine("double value:" + n2);
            //Console.WriteLine("string value:" + name);


            //string firstName = "sona";
            //string lastName = "varghese";
            //Console.WriteLine("name:"+firstName+" "+ lastName);


            //int num = 4;
            //string result =num.ToString();
            //Console.WriteLine(result);


            //int a = 4;
            //int b = 5;
            //int sum = a + b;
            //Console.WriteLine("sum of "+a+" + "+b+" is " + sum);


            //Console.WriteLine("enter the first no:");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the second no:");
            //int y = Convert.ToInt32(Console.ReadLine());
            //int reminder = x % y;
            //Console.WriteLine("the reminder of " + x + " and " + y + " is " + reminder);


            //Console.WriteLine("Enter the array size:");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = new int[size];
            //Console.WriteLine("enter " + size + " numbers:");
            //for (int i = 0; i < size; i++)
            //{
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int largest = numbers[0];
            //int smallest = numbers[0];
            //foreach (int n in numbers)
            //{
            //    if (n>largest)
            //    {
            //        largest = n;
            //    }
            //    if (n < smallest)
            //    {
            //        smallest = n;
            //    }
            //}
            //Console.WriteLine("The largest no is:" + largest);
            //Console.WriteLine("The smallest no is:" + smallest);


            //Console.WriteLine("Enter the array size:");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = new int[size];
            //Console.WriteLine("enter " + size + " numbers:");
            //for (int i = 0; i < size; i++)
            //{
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int evencount = 0;
            //int oddcount = 0;
            //foreach (int n in numbers)
            //{
            //    if (n%2==0)
            //    {
            //        evencount++;
            //    }
            //    else
            //    {
            //        oddcount++;
            //    }
            //}
            //Console.WriteLine("even count:" + evencount);
            //Console.WriteLine("odd count:" + oddcount);

            //Console.WriteLine("Enter the array size:");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = new int[size];
            //int[] reversed = new int[size];
            //Console.WriteLine("enter " + size + " numbers:");
            //for (int i = 0; i < size; i++)
            //{
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int j = size-1,k=0; j >=0;k++, j--)
            //{
            //    reversed[k] = numbers[j];
            //}
            //Console.WriteLine("reversed array:");
            //foreach (var item in reversed)
            //{
            //    Console.WriteLine(item + " ");
            //}
            //int sum = 0;
            //foreach (int n in numbers)
            //{
            //    sum += n;
            //}
            //Console.WriteLine("sum of array elements are:" + " " + sum);


            //Student student1 = new Student();
            //student1.Name = "sona";
            //student1.Age = 24;
            //Console.WriteLine("Name:" + student1.Name);
            //Console.WriteLine("Age:" + student1.Age);

            //List<int> num1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            //List<int> num2 = new List<int>(num1);
            //num2.Add(7);
            //num2.Remove(5);
            //Console.WriteLine("num1:" + string.Join(", " ,num1));
            //Console.WriteLine("num2: " + string.Join(", " , num2));


            Dictionary<int, string> Students = new Dictionary<int, string>();
            Students.Add(1, "sona");
            Students.Add(2, "angel");
            Console.WriteLine("students are:");
            foreach (var item in Students)
            {
                Console.WriteLine($"id:{item.Key} name:{item.Value}");
            }


        }
    }
}
