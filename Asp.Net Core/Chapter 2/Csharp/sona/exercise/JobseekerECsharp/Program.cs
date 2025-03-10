namespace JobseekerECsharp
{
    internal class Program
    {
        struct Jobseeker
        {
            public string Name;
            public string Email;
            public string Password;
        }
        static Jobseeker[] jobseeker = new Jobseeker[5];
        static Jobseeker loggedinuser;
        static int count=0;
        static void Main(string[] args)
        {
            
            Console.WriteLine("");
            Display();
        }
        static void Display()
        {
            Console.WriteLine("Welcome to the Job Portal!");
            Console.WriteLine("1.Register");
            Console.WriteLine("2.Login");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Register();
                    break;
                case "2":
                    Login();
                    break;
                default:
                    Console.WriteLine("Enter a valid input");
                    Display();
                    break;
            }
        }
        static void Register()
        {
            jobseeker[count] =new Jobseeker();

            Console.WriteLine("Register");
            Console.WriteLine("Enter the name:");
            jobseeker[count].Name = Console.ReadLine();
            Console.WriteLine("Enter email:");
            jobseeker[count].Email = Console.ReadLine();
            Console.WriteLine("Enter password:");
            jobseeker[count].Password = Console.ReadLine();
            count++;
            Console.WriteLine("Registration Successfull");
            Console.WriteLine("Welcome to the Jobseeker Portal!");
            Display();
        }
        static void Login()
        {
            Console.WriteLine("Enter your email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string pass = Console.ReadLine();
            bool isAuthenticated = false;
            for (int i=0;i< count;i++)
            {
                if (jobseeker[i].Email==email && jobseeker[i].Password==pass)
                {
                    loggedinuser = jobseeker[i];
                    Console.WriteLine("Login Successful!");
                    Console.WriteLine($"Welcome {jobseeker[i].Name}");
                    isAuthenticated = true;
                    Dashboard();
                    return;

                }
                    
                
            }
            Console.WriteLine("Please enter correct email id or password. If you are not register then register first.");

            Display();

        }
        static void Dashboard()
        {
            Console.WriteLine("1.List all jobs");
            Console.WriteLine("2.My Profile");
            Console.WriteLine("3.Logout");
            string choice2 = Console.ReadLine();
            switch (choice2)
            {
                case "1":
                    Listjobs();
                    break;
                case "2":Myprofile();
                    break;
                case "3":
                    Console.WriteLine("Logged out successfully! ");
                    Display();
                    break;
                default:
                    Console.WriteLine("Please enter valid input");
                    Dashboard();
                    break;
            }
        }
        static void Listjobs()
        {
            Console.WriteLine("Jobs Available:");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"|{"ID",-5}|{"Title",-20}|{"Experience",-20}|{"Company",-30}|{"Location",-10}|{"Salary Range",-20}|");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            string[,] data =
            {
                {"1","Software Engineer","3+ years","Acme Inc.New York","NY","$100,000 - $150,000" },
                {"2","Product Manager","5+ years","Globex Corp.San Francisco","CA","$120,000 - $180,000"},
                {"3","Marketing Specialist","2+ years","Hoolie Enterprises Seattle","WA","$70,000 - $90,000"}
            };
            for (int i = 0; i < data.GetLength(0); i++)
            {
                Console.WriteLine($"|{data[i, 0],-5}|{data[i, 1],-20}|{data[i, 2],-20}|{data[i, 3],-30}|{data[i, 4],-10}|{data[i,5],-20}|");
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

            Dashboard();
        }
        static void Myprofile()
        {
            Console.WriteLine($"Name : {loggedinuser.Name}");
            Console.WriteLine($"Email : {loggedinuser.Email}");
            Console.WriteLine($"Password : {loggedinuser.Password}");
            Dashboard();
        }
    }
}
