using System.ComponentModel.DataAnnotations;

namespace structStudent
{
    struct Student
    {
        public int RollNumber;
        public string Name;
        public double Marks;

        public Student(int rollno,string name,double mark)
        {
            RollNumber = rollno;
            Name = name;
            Marks = mark;
        }
        public void Display()
        {
            Console.WriteLine($"RollNumber:{RollNumber},Name:{Name},Marks:{Marks}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Enter the details of student {i + 1}:");
                Console.WriteLine("Enter RollNumber:");
                int rollno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter mark:");
                double mark = Convert.ToDouble(Console.ReadLine());

                students[i] = new Student(rollno, name, mark);
            }
            var sortedlist = students.OrderByDescending(s => s.Marks).ToArray();
            foreach (Student item in sortedlist)
            {
                item.Display();
            }
        }
    }
}
