using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asyn_Pgm
{
    internal class Program
    {

        static async void LongProcess()
        {
            Console.WriteLine("LongProcess started");
            //Thread.Sleep(4000);
            Console.WriteLine("LongProcess Completed");
        }

        public static async void ShortPreocess()
        {
            Console.WriteLine("ShortProcess Started");
            //await Task.Delay(1000);
            Console.WriteLine("ShortProcess Completed");
        }
        static async Task Main(string[] args)
        {
            LongProcess();
            ShortPreocess();

            Console.ReadLine();
        }
        //Console.ReadLine();
    }
}
