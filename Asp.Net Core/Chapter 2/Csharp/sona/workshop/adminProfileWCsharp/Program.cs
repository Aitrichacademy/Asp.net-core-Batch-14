namespace adminProfileWCsharp
{
    internal class Program
    {
        struct adminProfile
        {
            public string name;
            public string username;
            public string email;
            public long phone;
        }
        static void Main(string[] args)
        {
            adminProfile[] admin = new adminProfile[1];
            bool isregistered = false;
            string ch;

            Console.WriteLine("********************************");
            Console.WriteLine("************  ADMIN *************");
            Console.WriteLine("********************************\n");
            Console.WriteLine("A : Register as an admin");
            Console.WriteLine("D : To view the admin details");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Select option A or D (a or d)");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "A":
                    case "a":
                        if (isregistered)
                        {
                            Console.WriteLine("Asmin is already registered..!");
                        }
                        else
                        {
                            Console.WriteLine("Enter the admin's name:");
                            admin[0].name = Console.ReadLine();
                            Console.WriteLine("Enter the username:");
                            admin[0].username = Console.ReadLine();
                            Console.WriteLine("Enter the email");
                            admin[0].email = Console.ReadLine();
                            Console.WriteLine("Enter the phone no:");
                            admin[0].phone = Convert.ToInt64(Console.ReadLine());
                            isregistered = true;
                            Console.WriteLine("Admin registered successfully..");
                        }
                            break;
                    case "D":
                    case "d":
                        if (isregistered)
                        {
                            Console.WriteLine("Admin details are:");
                            Console.WriteLine($"Name :{admin[0].name}");
                            Console.WriteLine($"User name:{admin[0].username}");
                            Console.WriteLine($"Phone no:{ admin[0].phone}");
                        }
                        else
                        {
                            Console.WriteLine("Please register..");
                        }
                            break;
                }
                Console.WriteLine("Do you want to continue (Y or N)");
                ch =Console.ReadLine();

            }
            while (ch=="Y" || ch=="y");
            
        }
    }
}
