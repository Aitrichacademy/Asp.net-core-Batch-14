namespace structRectangle
{
    struct Rectangle
    {
        public double Length;
        public double Width;
        public Rectangle(double length,double width)
        {
            Length = length;
            Width = width;
        }
        public double GetArea()
        {
            return Length * Width;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the length:");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the width:");
            double width = Convert.ToDouble(Console.ReadLine());

            Rectangle rect = new Rectangle(length, width);

            Console.WriteLine("The area is:"+rect.GetArea());

        }
    }
}
