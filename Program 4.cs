using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic10._4
{
    class Point
    {
        private double x;
        private double y;

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Point(double value)
        {
            this.x = value;
            this.y = value;
        }
        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        public void Show()
        {
            Console.WriteLine($"Точка: ({x}, {y})");
        }
        static void Main(string[] args)
        {
            Point a = new Point(3.5, 5.2);
            a.Show();

            Point b = new Point(6.1);
            b.Show();

            Point c = new Point();
            c.Show();

        }
    }
}
