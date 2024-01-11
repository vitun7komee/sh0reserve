using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Circle : Methods
    {
        private Point p1, p2;
        public Circle(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public Point P1
        {
            get { return p1; }
            set { p1 = value; }
        }
        public Point P2
        {
            get { return p2; }
            set { p2 = value; }
        }

        public override void Move(double deltaX, double deltaY)
        {
            p1.x += deltaX;
            p1.y += deltaY;
            p2.x += deltaX;
            p2.y += deltaY;
        }
        public override bool IsValid()
        {
            double radius = Math.Sqrt(Math.Pow((p1.x - p2.x), 2) + Math.Pow((p1.y - p2.y), 2));

            return radius > 0;
        }
        public override double Area()
        {
            double radius = Math.Sqrt(Math.Pow((p1.x - p2.x), 2) + Math.Pow((p1.y - p2.y), 2));

            return 3.14 * Math.Pow(radius, 2);
        }
        public override double Perimeter()
        {
            double radius = Math.Sqrt(Math.Pow((p1.x - p2.x), 2) + Math.Pow((p1.y - p2.y), 2));

            return 2 * 3.14 * radius;
        }
    }
}
