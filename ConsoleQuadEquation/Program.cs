using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuadEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0;
            bool f, g, h;
            do
            {
                Console.Write("Введить значення a=");
                f = double.TryParse(Console.ReadLine(), out a);
                if (f == false)
                {
                    Console.WriteLine("Помилка! Введить коректне значення");
                }
            }
            while (!f);

            do
            {
                Console.Write("Введить значення b=");
                g = double.TryParse(Console.ReadLine(), out b);
                if (g == false)
                {
                    Console.WriteLine("Помилка! Введить коректне значення");
                }
            }
            while (!g);

             do
            {
                Console.Write("Введить значення c=");
                h = double.TryParse(Console.ReadLine(), out c);
                if (h == false)
                {
                    Console.WriteLine("Помилка! Введить коректне значення");
                }
            }
            while (!h);

            double D = Math.Pow(b, 2) - (4 * a * c);
            Console.WriteLine("D="+D);
            if(D>0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1="+x1);
                Console.WriteLine("x2="+x2);
            }
            if(D==0)
            {
               double x = (-b) / (2 * a);
               Console.WriteLine("x="+x);
            }
            if(D<0)
            {
                Console.WriteLine("D не має коренив");
            }

        }
    }
}
