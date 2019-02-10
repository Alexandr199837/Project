using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача3_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            double f;
            for(double x=-3; x<=0;x=x+0.1)
            {
                f = (Math.Pow(x, 2) - Math.Pow(Math.E, x)) * Math.Tan(Math.PI * x / 3);
                Console.WriteLine("f(x) " + f);
            }
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey();
        }
    }
}
