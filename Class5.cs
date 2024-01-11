using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Trapezoid : Methods
    {
        private Point p1, p2, p3, p4;

        public Trapezoid(Point p1, Point p2, Point p3, Point p4)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
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
        public Point P3
        {
            get { return p3; }
            set { p3 = value; }
        }
        public Point P4
        {
            get { return p4; }
            set { p4 = value; }
        }

        public override void Move(double deltaX, double deltaY)
        {
            p1.x += deltaX;
            p1.y += deltaY;
            p2.x += deltaX;
            p2.y += deltaY;
            p3.x += deltaX;
            p3.y += deltaY;
            p4.x += deltaX;
            p4.y += deltaY;

        }
        public override bool IsValid()
        {

            double side1 = Math.Sqrt(Math.Pow((p1.x - p2.x), 2) + Math.Pow((p1.y - p2.y), 2));
            double side3 = Math.Sqrt(Math.Pow((p2.x - p3.x), 2) + Math.Pow((p2.y - p3.y), 2));
            double side2 = Math.Sqrt(Math.Pow((p3.x - p4.x), 2) + Math.Pow((p3.y - p4.y), 2));
            double side4 = Math.Sqrt(Math.Pow((p1.x - p4.x), 2) + Math.Pow((p1.y - p4.y), 2));

            return side1 * side2 * side3 * side4 != 0;
        }
        public override double Area()
        {
            double side1 = Math.Sqrt(Math.Pow((p1.x - p2.x), 2) + Math.Pow((p1.y - p2.y), 2));
            double side3 = Math.Sqrt(Math.Pow((p2.x - p3.x), 2) + Math.Pow((p2.y - p3.y), 2));
            double side2 = Math.Sqrt(Math.Pow((p3.x - p4.x), 2) + Math.Pow((p3.y - p4.y), 2));
            double side4 = Math.Sqrt(Math.Pow((p1.x - p4.x), 2) + Math.Pow((p1.y - p4.y), 2));

            return (side1 + side2) / 2 * Math.Sqrt(side3 * side3 - Math.Pow(((side1 - side2) * (side1 - side2) + side3 * side3 - side4 * side4) / (2 * (side1 - side2)), 2));
        }
        public override double Perimeter()
        {
            double side1 = Math.Sqrt(Math.Pow((p1.x - p2.x), 2) + Math.Pow((p1.y - p2.y), 2));
            double side3 = Math.Sqrt(Math.Pow((p2.x - p3.x), 2) + Math.Pow((p2.y - p3.y), 2));
            double side2 = Math.Sqrt(Math.Pow((p3.x - p4.x), 2) + Math.Pow((p3.y - p4.y), 2));
            double side4 = Math.Sqrt(Math.Pow((p1.x - p4.x), 2) + Math.Pow((p1.y - p4.y), 2));

            return side1 + side2 + side3 + side4;
        }
    }
}
