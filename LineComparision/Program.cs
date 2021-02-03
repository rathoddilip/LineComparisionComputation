using System;

namespace LineComparision
{
    /// <summary>
    /// /
    /// </summary>
    class Point
    {
        /// <summary>
        /// The x and y are two co-ordinates of a point
        /// They are initialised using a constructor
        /// </summary>
        public int x;
        public int y;
        public Point(int xValue, int yValue)
        {
            x = xValue;
            y = yValue;
        }
    }
    class Line
    {
        /// <summary>
        /// Line consists of two points a and b
        /// This class is used to compare
        /// </summary>
        public Point a;
        public Point b;
        public Line(Point aValue, Point bValue)
        {
            a = aValue;
            b = bValue;
        }

        public double calculateLength()
        {
            return Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2)); ;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line comparison computation");

            Point a = new Point(3, 2);
            Point b = new Point(3, 5);
            Line l = new Line(a, b);

            Console.WriteLine("Length of line l: " + l.calculateLength());

        }
    }
}
