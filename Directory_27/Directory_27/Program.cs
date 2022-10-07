using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sfileName = @"mytest.txt";
            string tfileName = @"mynewtest.txt";


            if (File.Exists(sfileName))
            {
                File.Delete(sfileName);
            }
            if (File.Exists(tfileName))
            {
                File.Delete(tfileName);
            }
            Console.Write("\n Create a file and move the file in same folder to another name  \n");
            Console.Write("----------------------------------------------------------------\n\n");
            // Create the file.
            using (StreamWriter fileStr = File.CreateText(sfileName))
            {
                fileStr.WriteLine(" Hello and Welcome");
                fileStr.WriteLine(" It is the first content");
                fileStr.WriteLine(" of the text file mytest.txt");
            }
            using (StreamReader sr = File.OpenText(sfileName))
            {
                string s = "";
                Console.WriteLine(" Here is the content of the file {0} : ", sfileName);
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("");
            }
            System.IO.File.Move(sfileName, tfileName); 
            Console.WriteLine(" The file {0} successfully moved to the name {1} in the same directory ", sfileName, tfileName);

            using (StreamReader sr = File.OpenText(tfileName))
            {
                string s = "";
                Console.WriteLine(" Here is the content of the file {0} : ", tfileName);
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
