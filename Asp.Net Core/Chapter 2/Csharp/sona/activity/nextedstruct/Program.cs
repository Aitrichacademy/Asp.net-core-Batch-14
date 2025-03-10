namespace nextedstruct
{
    struct Company
    {
        public struct Department
        {
            public string DeptName;
            public string Manager;

            public Department(string deptname,string manager)
            {
                DeptName = deptname;
                Manager = manager;
            }
            public void Display()
            {
                Console.WriteLine($"DeptName:{DeptName},Manager:{Manager}");
            }
        }
        public string CompanyName;
        public Department Dept;

        public Company(string companyname,Department dept)
        {
            CompanyName = companyname;
            Dept = dept;
        }
        public void Display()
        {
            Console.WriteLine($"CompanyName:{CompanyName}");
            Dept.Display();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter Company Name:");
            string companyname = Console.ReadLine();
            Console.WriteLine("enter department Name:");
            string deptname = Console.ReadLine();
            Console.WriteLine("enter manager Name:");
            string manager = Console.ReadLine();

            Company.Department department = new Company.Department(deptname, manager);
            Company company = new Company(companyname, department);

            company.Display();

        }
    }
}
