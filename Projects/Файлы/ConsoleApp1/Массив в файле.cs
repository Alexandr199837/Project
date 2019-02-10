using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] massiv = new string[5] { "red", "green", "white", "black", "blue" };
            File.Delete("h:\\massiv.txt");
            FileStream massiv1 = new FileStream("h:\\massiv.txt", FileMode.CreateNew,FileAccess.Write);
            StreamWriter write = new StreamWriter(massiv1);
            for(int i = 0; i<massiv.Length; i++)
            {
                write.WriteLine(massiv[i]);
            }
            write.Close();
            FileStream massiv10 = new FileStream("h:\\massiv.txt", FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(massiv10);
            Console.WriteLine(read.ReadToEnd());
            read.Close();
            Console.ReadKey();


        }
    }
}
