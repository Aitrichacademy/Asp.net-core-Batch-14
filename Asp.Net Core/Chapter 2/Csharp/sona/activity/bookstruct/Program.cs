namespace bookstruct
{
    struct Book
    {
        public string Title;
        public string Author;
        public double Price;

        public Book(string title,string author,double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }
        public void Display()
        {
            Console.WriteLine($"Title:{Title} , Author: {Author} ,Price : {Price}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[3];
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"Enter the details of {i + 1} book:");
                Console.WriteLine("Enter the title:");
                string title = Console.ReadLine();
                Console.WriteLine("Enter the author:");
                string author = Console.ReadLine();
                Console.WriteLine("enter price:");
                double price = Convert.ToDouble(Console.ReadLine());
                books[i] = new Book(title,author,price);
            }
            foreach (Book item in books)
            {
                item.Display();
            }

        }
    }
}
