using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Login1,LOgin2,login3,loGin4";
            string[] array = s.Split(',');
            Console.WriteLine(s.ToLower());
            Console.ReadKey();

        }
    }
}