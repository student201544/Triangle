using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТРЕУГОЛЬНИК2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle[] mass = new Triangle[5];

            Point p10 = new Point(1, 0);
            Point p20 = new Point(1, 5);
            Point p30 = new Point(6, 0);
            mass[0] = new Triangle(p10, p20, p30);

            Point p11 = new Point(0, 1);
            Point p21 = new Point(6, 1);
            Point p31 = new Point(3, 10);
            mass[1] = new Triangle(p11, p21, p31);

            Point p12 = new Point(0, 0);
            Point p22 = new Point(0, 7);
            Point p32 = new Point(5, 0);
            mass[2] = new Triangle(p12, p22, p32);

            Point p13 = new Point(2, 1);
            Point p23 = new Point(10, 1);
            Point p33 = new Point(6, 12);
            mass[3] = new Triangle(p13, p23, p33);

            Point p14 = new Point(3, 3);
            Point p24 = new Point(3, 7);
            Point p34 = new Point(9, 3);
            mass[4] = new Triangle(p14, p24, p34);


            double count_rights = 0;        // кол-во прямоугольных треугольников
            double sum_perim = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i].Right())
                {

                    count_rights++;
                    sum_perim += mass[i].Perimetr();
                    Console.WriteLine("треугольник {0} - прямоугольный, его периметр = {1}", i, mass[i].Perimetr());


                }
            }
            Console.WriteLine("кол-во прямоугольных треугольников = {0}", count_rights);
            double middle_perim = 0;
            middle_perim = sum_perim / count_rights; // средний периметр прямоугольных треугольников
            Console.WriteLine("средний периметр = {0}", middle_perim);

            double count_isosceles = 0;
            double sum_area = 0;
            for (int i = 0; i < mass.Length; i++)
            {

                if (mass[i].Isosceles())
                {
                    count_isosceles++;
                    sum_area += mass[i].Area();
                    Console.WriteLine("треугольник {0} - равнобедренный, его площадь = {1}", i, mass[i].Area());
                }
            }
            Console.WriteLine("кол-во равнобедренных треугольников = {0}", count_isosceles);
            double middle_area = 0;
            middle_area = sum_area / count_isosceles; // средняя площадь равнобедренных треугольников
            Console.WriteLine("средняя площадь = {0}", middle_area);
            Console.ReadKey();
        }
    }
}

