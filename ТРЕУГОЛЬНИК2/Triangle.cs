using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТРЕУГОЛЬНИК2
{
    public class Triangle
    {
        public Point c { get; set; }
        public Point d { get; set; }
        public Point e { get; set; }

        public Triangle(Point c1, Point d1, Point e1) //объекты класса Triangle состоят из трех объектов класса Point
        {

            if (!Check(c1, d1, e1))
            {
                throw new TriangleNotExistException();
            }

            c = c1;
            d = d1;
            e = e1;
        }

        private static bool Check(Point pointfirst, Point pointsecond, Point pointthird)
        {
            Edge edge1 = new Edge(pointfirst, pointsecond);
            Edge edge2 = new Edge(pointfirst, pointthird);
            Edge edge3 = new Edge(pointsecond, pointthird);

            if ((edge1.Lenght + edge2.Lenght > edge3.Lenght) || (edge2.Lenght + edge3.Lenght > edge1.Lenght) || (edge1.Lenght + edge3.Lenght > edge2.Lenght))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private class TriangleNotExistException : Exception
        {
            public string Messege
            {
                get
                {
                    return "Такой треугольник не может существовать!";
                }
            }
         }

        public double Perimetr() //периметр
        {

            double perim = Edge.lengthEdge(c, d) + Edge.lengthEdge(c, e) + Edge.lengthEdge(d, e);

            return perim;
        }
        public double Area()  //площадь
        {

            double p = this.Perimetr() / 2;

            double ar = Math.Sqrt(p * (p - Edge.lengthEdge(c, d)) * (p - Edge.lengthEdge(c, e)) * (p - Edge.lengthEdge(d, e)));

            return ar;
        }

        public bool Right() // прямоугольный треугольник?    (a^2 + b^2 = f^2)
        {
            double a = Math.Round(Math.Pow(Edge.lengthEdge(c, d), 2));
            double b = Math.Round(Math.Pow(Edge.lengthEdge(c, e), 2));
            double f = Math.Round(Math.Pow(Edge.lengthEdge(d, e), 2));



            if ((a == (b + f)) || (b == (a + f)) || (f == (a + b)))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Isosceles()   //равнобедренные треугольник?
        {
            double a = Edge.lengthEdge(c, d);
            double b = Edge.lengthEdge(c, e);
            double f = Edge.lengthEdge(d, e);

            if ((a == b) || (b == f) || (f == a))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

