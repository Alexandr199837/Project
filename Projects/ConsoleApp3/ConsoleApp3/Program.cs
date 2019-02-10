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
            try
            {
                Console.WriteLine("Введите количество сторон:");
                int N = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите радиус:");              
                int Radius = Convert.ToInt32(Console.ReadLine());
                double S = Math.Tan(Math.PI / N) * Math.Pow(Radius, 2) * N;
                if (N < 3)
                {
                    Console.WriteLine("У многоугольника минимум 3 стороны.Будьте внимательнее!");
                    Console.WriteLine("Нажмите любую клавишу для выхода");
                    Console.ReadKey();
                }
                else
                {
                    Console.Write("Площадь фигуры равна:" + S);
                    Console.WriteLine("Нажмите любую клавишу для выхода");
                    Console.ReadKey();
                }
            }
            catch (FormatException)

            {
                Console.WriteLine("Вы ввели не число");
                Console.WriteLine("Нажмите любую клавишу для выхода");
                Console.ReadKey();
            }
        
                
            
        }
    }
}
