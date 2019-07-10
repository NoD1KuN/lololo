using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    class Program
    {
        static double a;
        static double b;
        static double e;
        static double x0;

        static double f(double x)
        {
            return (x - 1) * (x - 1) - Math.Pow(Math.E, x) / 2;
        }

        static double Proizv(double x)
        {
            return 2 * x - 2 - Math.Pow(Math.E, x) / 2;
        }

        static void Dih()
        { 
            double c;
            int s = 0;
            while (true)
            {
                s++;
                c = (a + b) / 2;
                Console.WriteLine(s + ": " + c);
                if (Math.Abs(f(c)) < e) break;
                if (f(a) * f(c) < 0) b = c;
                else a = c;
            }
            Console.WriteLine("Итог : " + c);
            Console.WriteLine("Кол-во итераций: " + s);
        }

        static void Nuton()
        {
            double xn = x0;
            double xn1;
            int s = 0;                           
            while (true)
            {
                s++;
                xn1 = xn - f(xn) / Proizv(xn);
                Console.WriteLine(s + ": " + xn1);
                if (Math.Abs((xn1 - xn)) < e) break;
                xn = xn1;
            }
            Console.WriteLine("Итог : " + xn1);
            Console.WriteLine("Кол-во итераций: " + s);
        }

        static void Main(string[] args)
        {
            a = 0;
            b = 0.5;
            e = 0.001;
            x0 = (a + b) / 2;
            Console.WriteLine("Метод дихотомии");
            Dih();
            Console.WriteLine("");
            Console.WriteLine("Метод Ньютона");
            Nuton();
        }
    }
}
