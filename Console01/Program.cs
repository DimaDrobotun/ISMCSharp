using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console01
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, x = 0, y = 0;
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
                Console.Write("Введить значення x=");
                h = double.TryParse(Console.ReadLine(), out x);
                if (h == false)
                {
                    Console.WriteLine("Помилка! Введить коректне значення");
                }
            }
            while (!h);

            y = 2.4 * (Math.Abs(Math.Pow(x, 2) + b) / a) + (a - b) *Math.Pow(Math.Sin(1),2)* (a - b) + Math.Pow(10, -2) * (x - b);
            Console.WriteLine(y);
        }
    }
}
