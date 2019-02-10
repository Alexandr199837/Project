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
            int[][] array = new int[5][];     
            array[0] = new int[3];
            array[1] = new int[2];
            array[2] = new int[5];
            array[0][1] = 1;
            array[1][1] = 2;
            Console.WriteLine(array[0][1]);
            Console.ReadKey();
        }
    }
}
