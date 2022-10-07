using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Pgm
{
    public delegate void SimpleInterest(int x, double y, int z);
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleInterest obj = delegate (int p, double r, int t)
            {
                Console.WriteLine("Simple Interest = " +(p*r*t)/100);
            };

            Console.WriteLine("Enter the principle : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the rate ; ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the time : ");
            int c = int.Parse(Console.ReadLine());
            obj.Invoke(a, b, c);

            Console.ReadLine(); 
        }
    }
}
