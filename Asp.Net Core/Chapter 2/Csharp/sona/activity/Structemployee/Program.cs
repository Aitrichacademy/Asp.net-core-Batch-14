namespace Structemployee
{
    struct Employee
    {
        int ID;
        string Name;
        double Salary;

        public Employee(int id,string name,double salary)
        {
            ID = id;
            Name = name;
            Salary = salary;
        }
        public void Display()
        {
            Console.WriteLine($"ID:{ID},Name:{Name},Salary:{Salary}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Enter the details of employee {i+1}");
                Console.WriteLine("Enter the id:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the salary:");
                double salary = Convert.ToDouble(Console.ReadLine());

                employees[i] = new Employee(id,name,salary);
            }

            foreach (Employee item in employees)
            {
                item.Display();
            }
        }
    }
}
