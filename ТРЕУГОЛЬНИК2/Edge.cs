using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТРЕУГОЛЬНИК2
{
    public class Edge
    {
        public Point a { get; set; }
        public Point b { get; set; }
        public double lenght { get; set; }

        public Edge(Point s, Point m) //объекты класса Edge состоят из двух объектов класса Point
        {
            a = s;
            b = m;
            lenght = lengthEdge(s, m);
        }

        public static double lengthEdge(Point a, Point b)       //длина ребра
        {
            return Math.Sqrt(Math.Pow((b.x - a.x), 2) + Math.Pow((b.y - a.y), 2));           
        }

        public double Lenght
        {
            get
            {
                return lenght;
            }
        }
    }
}

