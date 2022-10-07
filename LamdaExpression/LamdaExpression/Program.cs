////Write a delegate which will take one integer argument.
////And write functions for factorial, Fibonacci, Factors of number, Table of Number and call the functions through delegate.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace deligates
{
    public delegate void algo(int i);
    internal class Program
    {
        public static void factorial(int a)
        {
            int m = 1;
            for (int i = a; i >= 1; i--)
            {
                m *= i;
            }



            Console.WriteLine(m);
        }
        public static void fab(int a)
        {
            int m = 1;
            int n = 1;
            int k = 0;
            if (a == 1 || a == 2)
            {
                Console.WriteLine("{0}th term of fibonacii series is", a);
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 3; i <= a; i++)
                {
                    k = m + n;
                    n = m;
                    m = k;
                }

                Console.WriteLine("{0}th term of fibonacii series is", a);
                Console.WriteLine(k);
            }

        }
        public static void factor(int a)
        {
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void table(int a)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} ={2}", a, i, a * i);
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("enter the number for table");

            int a = Convert.ToInt32(Console.ReadLine());
            algo obj = new algo(table);
            obj.Invoke(a);
            Console.WriteLine("enter the number for factorial");
            int b = Convert.ToInt32(Console.ReadLine());
            obj = factorial;
            obj.Invoke(b);
            Console.WriteLine("enter the number for fibonacii");
            int c = Convert.ToInt32(Console.ReadLine());
            obj = fab;
            obj.Invoke(c);
            Console.WriteLine("enter the number for finding factor");
            int d = Convert.ToInt32(Console.ReadLine());
            obj = factor;
            obj.Invoke(d);

            Console.ReadLine();
        }
    }
}
