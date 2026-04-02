using System;

namespace AdvancedExercise_PolymorphismWithInterfaces
{
    public interface IShape
    {
        double GetArea();
    }

    public class Circle : IShape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            // Using Math.PI for high precision
            return Math.PI * _radius * _radius;
        }
    }

    public class Rectangle : IShape
    {
        private double _width;
        private double _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public double GetArea()
        {
            return _width * _height;
        }
    }

    public class Exercise
    {
        public void PrintAreas()
        {
            // Create the array with the specific dimensions provided
            IShape[] shapes = new IShape[]
            {
                new Circle(5),
                new Rectangle(4, 6)
            };

            foreach (IShape shape in shapes)
            {
                // Format matches "Area: [value]"
                Console.WriteLine($"Area: {shape.GetArea()}");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.PrintAreas();

            Console.ReadKey();
        }
    }
}