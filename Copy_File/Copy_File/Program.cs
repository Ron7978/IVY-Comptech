using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_File
{
    class Program
    {
        static void Main()
        {
            string sfileName = @"mytest.txt";
            string tfileName = @"mynewtest.txt";

            
            if (File.Exists(sfileName))
            {
                File.Delete(sfileName);
            }
            Console.Write("\n Create a file and copy the file  \n");
            Console.Write("----------------------------------\n");

            using (StreamWriter fileStr = File.CreateText(sfileName))
            {
                fileStr.WriteLine(" Hello and Welcome");
                fileStr.WriteLine(" India is a great country");
                fileStr.WriteLine(" Amazing opportunity to establish a good carrer");
                fileStr.WriteLine("\n\n");
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

            System.IO.File.Copy(sfileName, tfileName, true);
            Console.WriteLine(" The file {0} successfully copied to the name {1} in the same directory", sfileName, tfileName);

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
