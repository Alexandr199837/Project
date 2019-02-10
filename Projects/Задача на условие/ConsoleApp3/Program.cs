using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, g;
            Console.WriteLine("Введите голы хозяев");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите голы гостей");
            g = Convert.ToInt32(Console.ReadLine());
            if (x < g)
            {
                Console.WriteLine("Победили гости");       
            }
            else if (x > g)
            {
                Console.WriteLine("Победили хозяева");
            }
            else
            {
                Console.WriteLine("Ничья");
            }
            Console.ReadKey();
        }
    }
}
