using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 7;
            double s, c;
            s = 0.5 * a * b;
            c = Math.Sqrt(a * a + b * b);
            Console.WriteLine(c);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
