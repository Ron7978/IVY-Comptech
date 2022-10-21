using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\bhattacharya.rounak\\OneDrive - Entain Group\\First_Folder";
            Directory.CreateDirectory(path);
            FileStream fs = new FileStream(path + "\\file1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Hi This is Rounak, \n The Content of file-1\n now the file will get swap to another folder");
            sw.Close();
            fs.Close();
            path = "C:\\Users\\bhattacharya.rounak\\OneDrive - Entain Group\\Second_Folder";
            Directory.CreateDirectory(path);
            fs = new FileStream(path + "\\file2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            sw = new StreamWriter(fs);
            sw.WriteLine("Hi This is Sonali, \n The Content of file-2\n now the file will get swap to another folder");
            sw.Close();
            fs.Close();
            File.Move("C:\\Users\\bhattacharya.rounak\\OneDrive - Entain Group\\First_Folder\\file1.txt", "C:\\Users\\bhattacharya.rounak\\OneDrive - Entain Group\\Second_Folder\\file1.txt" );
            File.Delete("C:\\Users\\bhattacharya.rounak\\OneDrive - Entain Group\\First_Folder\\file1.txt");
            File.Move("C:\\Users\\bhattacharya.rounak\\OneDrive - Entain Group\\Second_Folder\\file2.txt", "C:\\Users\\bhattacharya.rounak\\OneDrive - Entain Group\\First_Folder\\file2.txt");
            File.Delete("C:\\Users\\bhattacharya.rounak\\OneDrive - Entain Group\\Second_Folder\\file2.txt");
            
            
            Console.ReadKey();
        }
    }
}
