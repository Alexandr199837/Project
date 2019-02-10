using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача3
{
    class Program
    {
        static void Main(string[] args)
        {
            double f, x = -3;
            while(x<=0)
            {
                f = (Math.Pow(x, 2) - Math.Pow(Math.E, x)) * Math.Tan(Math.PI * x / 3);
                x = x + 0.1;
                Console.WriteLine(f);
               
            }
            Console.ReadKey();
        }
    }
}
