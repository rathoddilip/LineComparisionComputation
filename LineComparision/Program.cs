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

        public double CalculateLength()
        {
            return Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2)); ;
        }

        public void Compare(Line l1)
        {
            if (l1.CalculateLength() == this.CalculateLength())
                Console.WriteLine("Lines are equal");
            else
                Console.WriteLine("Lines are not equal");
        }

        public void compareTo(Line l1)
        {
            double l1Length = l1.CalculateLength();
            double thisLineLength = this.CalculateLength();
            if (l1Length == thisLineLength)
                Console.WriteLine("Lines are equal");
            else if (l1Length > thisLineLength)
                Console.WriteLine("This line is smaller than Second Line");
            else
                Console.WriteLine("This line is greater than Second Line");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line comparision computation");

            Point a = new Point(3, 2);//called the constructor
            Point b = new Point(3, 5);
            Line l = new Line(a, b);

            Console.WriteLine("Length of line l: " + l.CalculateLength());

            Point a1 = new Point(3, 2);
            Point b1 = new Point(3, 5);
            Line l1 = new Line(a1, b1);

            Console.WriteLine("Length of line l1: " + l1.CalculateLength());
            l.Compare(l1);

            Point a2 = new Point(3, 2);
            Point b2 = new Point(3, 6);
            Line l2 = new Line(a2, b2);

            Console.WriteLine("Length of line l2: " + l2.CalculateLength());
            l.compareTo(l2);
        }
    }
}
