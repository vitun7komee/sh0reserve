using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Polygon : Methods
    {
        private Point[] points;

        public Polygon(Point[] points)
        {
            this.points = points;
        }

        public Point[] Points
        {
            get { return points; }
            set { points = value; }
        }

        public override void Move(double deltaX, double deltaY)
        {
            foreach (Point point in points)
            {
                point.x += deltaX;
                point.y += deltaY;
            }
        }

        public override bool IsValid()
        {
            int numPoints = points.Length;

            if (numPoints < 3)
            {
                return false;
            }

            for (int i = 0; i < numPoints; i++)
            {
                int j = (i + 1) % numPoints;
                int k = (i + 2) % numPoints;

                double side1 = Math.Sqrt(Math.Pow((points[i].x - points[j].x), 2) + Math.Pow((points[i].y - points[j].y), 2));
                double side2 = Math.Sqrt(Math.Pow((points[i].x - points[k].x), 2) + Math.Pow((points[i].y - points[k].y), 2));
                double side3 = Math.Sqrt(Math.Pow((points[j].x - points[k].x), 2) + Math.Pow((points[j].y - points[k].y), 2));

                if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
                {
                    return false;
                }
            }

            return true;
        }

        public override double Area()
        {
            int numPoints = points.Length;

            if (numPoints < 3)
            {
                return 0;
            }

            double area = 0;

            for (int i = 0; i < numPoints; i++)
            {
                int j = (i + 1) % numPoints;

                double crossProduct = points[i].x * points[j].y - points[j].x * points[i].y;
                area += crossProduct;
            }

            return Math.Abs(area / 2);
        }

        public override double Perimeter()
        {
            int numPoints = points.Length;

            if (numPoints < 3)
            {
                return 0;
            }

            double perimeter = 0;

            for (int i = 0; i < numPoints; i++)
            {
                int j = (i + 1) % numPoints;

                double side = Math.Sqrt(Math.Pow((points[i].x - points[j].x), 2) + Math.Pow((points[i].y - points[j].y), 2));
                perimeter += side;
            }

            return perimeter;
        }
    }
}
