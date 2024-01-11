using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Triangle : Methods
    {
        private Point p1, p2, p3;
        public Triangle(Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
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

        public override void Move(double deltaX, double deltaY)
        {
            p1.x += deltaX;
            p1.y += deltaY;
            p2.x += deltaX;
            p2.y += deltaY;
            p3.x += deltaX;
            p3.y += deltaY;
        }
        public override bool IsValid()
        {
            double side1 = Math.Sqrt(Math.Pow((p1.x - p2.x), 2) + Math.Pow((p1.y - p2.y), 2));
            double side2 = Math.Sqrt(Math.Pow((p1.x - p3.x), 2) + Math.Pow((p1.y - p3.y), 2));
            double side3 = Math.Sqrt(Math.Pow((p2.x - p3.x), 2) + Math.Pow((p2.y - p3.y), 2));

            return (side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1);
        }
        public override double Area()
        {

            double side1 = Math.Sqrt(Math.Pow((p1.x - p2.x), 2) + Math.Pow((p1.y - p2.y), 2));
            double side2 = Math.Sqrt(Math.Pow((p1.x - p3.x), 2) + Math.Pow((p1.y - p3.y), 2));
            double side3 = Math.Sqrt(Math.Pow((p2.x - p3.x), 2) + Math.Pow((p2.y - p3.y), 2));

            double semiPerimeter = (side1 + side2 + side3) / 2;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
        }
        public override double Perimeter()
        {
            double side1 = Math.Sqrt(Math.Pow((p1.x - p2.x), 2) + Math.Pow((p1.y - p2.y), 2));
            double side2 = Math.Sqrt(Math.Pow((p1.x - p3.x), 2) + Math.Pow((p1.y - p3.y), 2));
            double side3 = Math.Sqrt(Math.Pow((p2.x - p3.x), 2) + Math.Pow((p2.y - p3.y), 2));

            return side1 + side2 + side3;
        }
    }
}
