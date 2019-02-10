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
            int[] array1 = new int[10] { 10, 20, 25, 30, 41, 36, 18, 1, 49, 100 };
            foreach (int el in array1) 
            {if (el > 20 && el < 50)
                    Console.WriteLine(el);      }
            Console.ReadKey();
        }
    }
}
