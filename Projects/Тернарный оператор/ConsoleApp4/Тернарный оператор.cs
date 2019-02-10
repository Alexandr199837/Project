using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a % 7 == 0 && a % 3 == 0 ? "Кратно семи и трём" : "Не кратно семи и трём");
            Console.ReadKey();
            
        }
    }
}
