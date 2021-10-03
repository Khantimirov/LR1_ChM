using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace залечьнадновсанфранциско
{
    class Program
    {
        static void Main(string[] args)
        {
            double c = -0.1;
            int a = 0;
            int b = 1;
            int n = 0;
            double xn;
            double eps1 = 0.001;
            double x0;
            Console.WriteLine("МЕТОД ПРОСТЫХ ИТЕРАЦИЙ - ");
            while (true)
            {
                try
                {
                    Console.Write("Введите начальное приближение: ");
                    x0 = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Ащипка");
                }
            }
            Console.WriteLine("Точность:"+eps1);
            if (x0 > a && x0 < b)
            {
                while (true)
                {
                    xn = x0 + c * (Math.Pow(2.7, 2 * x0) + 3 * x0 - 4);
                    Console.WriteLine("n={0}, x0={1}, xn={2}, Delta={3}",n,x0,xn,Math.Abs(xn - x0));
                    n += 1;
                    if (Math.Abs(xn - x0) <= eps1 && (Math.Abs(Math.Pow(2.7, 2 * xn) + 3 * xn - 4)) <= eps1)
                    {
                        break;
                    }
                    else
                    {
                        x0 = xn;
                    }
                }
            }
            double eps2 = 0.00001;
            Console.WriteLine("Точность:" + eps2);
            n = 0;
            if (x0 > a && x0 < b)
            {
                while (true)
                {
                    xn = x0 + c * (Math.Pow(2.7, 2 * x0) + 3 * x0 - 4);
                    Console.WriteLine("n={0}, x0={1}, xn={2}, Delta={3}", n, x0, xn, Math.Abs(xn - x0));
                    n += 1;
                    if (Math.Abs(xn - x0) <= eps2 && (Math.Abs(Math.Pow(2.7, 2 * xn) + 3 * xn - 4)) <= eps2)
                    {
                        break;
                    }
                    else
                    {
                        x0 = xn;
                    }
                }
            }
            else
            {
                Console.WriteLine("Ащипка");
            }
            Console.WriteLine("МЕТОД НЬЮТОНА");
            n = 0;
            while (true)
            {
                try
                {
                    Console.Write("Введите начальное приближение: ");
                    x0 = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Ащипка");
                }
            }
            Console.WriteLine("Точность: "+eps1);
            while (true)
            {
                xn = x0 - (Math.Pow(Math.E, 2 * x0) + 3 * x0 - 4) / (2 * Math.Pow(Math.E, x0) + 3);
                n += 1;
                Console.WriteLine("n={0}, x0={1}, xn={2}, Delta={3}", n, x0, xn, Math.Abs(xn - x0));
                if ( Math.Abs(xn - x0) <= eps1 && Math.Abs(Math.Pow(Math.E, 2 * xn) + 3 * xn - 4) <= eps1 )
                {
                    break;
                }
                else
                {
                    x0 = xn;
                    continue;
                }
            }
            Console.WriteLine("Точность: " + eps2);
            n = 0;
            while (true)
            {
                xn = x0 - (Math.Pow(Math.E, 2 * x0) + 3 * x0 - 4) / (2 * Math.Pow(Math.E, x0) + 3);
                n += 1;
                Console.WriteLine("n={0}, x0={1}, xn={2}, Delta={3}", n, x0, xn, Math.Abs(xn - x0));
                if (Math.Abs(xn - x0) <= eps2 && Math.Abs(Math.Pow(Math.E, 2 * xn) + 3 * xn - 4) <= eps2)
                {
                    break;
                }
                else
                {
                    x0 = xn;
                    continue;
                }
            }
            Console.WriteLine("МОДИФИЦИРОВАННЫЙ МЕТОД НЬЮТОНА");
            n = 0;
            while (true)
            {
                try
                {
                    Console.Write("Введите начальное приближение: ");
                    x0 = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Ащипка");
                }
            }
            Console.WriteLine("Точность: " + eps1);
            while (true)
            {
                xn = x0 - (Math.Pow(Math.E, 2 * 0) + 3 * x0 - 4) / (2 * Math.Pow(Math.E, 0) + 3);
                n += 1;
                Console.WriteLine("n={0}, x0={1}, xn={2}, Delta={3}", n, x0, xn, Math.Abs(xn - x0));
                if (Math.Abs(xn - x0) <= eps1 && Math.Abs(Math.Pow(Math.E, 2 * xn) + 3 * xn - 4) <= eps1)
                {
                    break;
                }
                else
                {
                    x0 = xn;
                    continue;
                }
            }
            Console.WriteLine("Точность: " + eps2);
            n = 0;
            while (true)
            {
                xn = x0 - (Math.Pow(Math.E, 2 * 0) + 3 * x0 - 4) / (2 * Math.Pow(Math.E, 0) + 3);
                n += 1;
                Console.WriteLine("n={0}, x0={1}, xn={2}, Delta={3}", n, x0, xn, Math.Abs(xn - x0));
                if (Math.Abs(xn - x0) <= eps2 && Math.Abs(Math.Pow(Math.E, 2 * xn) + 3 * xn - 4) <= eps2)
                {
                    break;
                }
                else
                {
                    x0 = xn;
                    continue;
                }
            }
        }
    }
}
