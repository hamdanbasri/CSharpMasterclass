namespace StructsApp
{
    public struct Point
    {
        public double X { get; }
        public double Y { get; }

        //public int X;
        //public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Point other)
        {
            double dx = other.X - X;
            double dy = other.Y - Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public void Display()
        {
            Console.WriteLine($"Point: ({X},{Y})");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10,20);
            p1.Display();

            Point p2 = new Point(20,30);
            p2.Display();

            double distance = p1.DistanceTo(p2);
            Console.WriteLine($"Distance between points: {distance:F2}");

            Point p3 = p1;
            p1.Display();
            p3.Display();

            Console.ReadKey();
        }
    }
}
