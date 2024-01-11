using System;
using System.Drawing;
using System.Net;
using System.Security.Policy;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2, 0);
            Point p2 = new Point(5, 0);
            Point p3 = new Point(4, 3);
            Point p4 = new Point(3, 3);
            Point p5 = new Point(7, 5);
            Point[] myPoints = new Point[5];
            myPoints[0] = p1;
            myPoints[1] = p2;
            myPoints[2] = p3;
            myPoints[3] = p4;
            myPoints[4] = p5;

            Triangle myTriangle = new Triangle(p1, p2, p3);
            Trapezoid myTrapezoid = new Trapezoid(p1, p2, p3, p4);
            Circle myCircle = new Circle(p1, p2);
            Polygon myPolygon = new Polygon(myPoints);

            Person myPerson = new Person();
            Person myPerson2 = new Person("Иванов Иван Иванович", 20);
            myPerson.talk();
            myPerson2.talk();
            Console.WriteLine(myPolygon.IsValid());
            Console.WriteLine(myPolygon.Perimeter());
        }
    }
}