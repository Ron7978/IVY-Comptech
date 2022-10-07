using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Lambda_2
{
    public delegate int funt1(int a);
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.Write("Enter the no : ");
            n = int.Parse(Console.ReadLine());
                        
            funt1 ff = (p1) =>
            {
                for (i = 0; i < n; i++)
                {
                    sum += i;
                }
                return sum;
            };
            int result = ff(n);
            Console.WriteLine("The Sum of 1 to n natural no : " + result);

            Console.ReadKey();
        }
    }
}
