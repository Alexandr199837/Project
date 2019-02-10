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
            int[] array1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] array2 = new int[10] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            int[] array3 = new int[10];
            for (int i = 0; i < array3.Length; i++) 
            Console.WriteLine(array3[i] = array1[i] + array2[i]);
            Console.ReadKey();
        
        }
    }
}
