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
            FileStream numbers = new FileStream("h:\\numbers5.txt", FileMode.CreateNew, FileAccess.Write);          
            StreamWriter number = new StreamWriter(numbers5);        
            for (int i = 1; i <= 500; i++)
            {
                number.Write("{0},", i);
            }
            number.Close();
            FileStream numbers1 = new FileStream("h:\\numbers5.txt", FileMode.Open, FileAccess.Read);
            StreamReader numbery = new StreamReader(numbers1);
            Console.WriteLine(numbery.ReadToEnd());
            Console.ReadKey();


        }
    }
}
