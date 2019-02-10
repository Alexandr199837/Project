using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите координаты X и Y:");
                double X = Convert.ToDouble(Console.ReadLine());
                double Y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(((Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2)) <= 2) && (Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2)) >= 1) && (Y > 0))? "Точка попадает в закрашенную область": "Точка не попадает в закрашенную область");
                    Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не числовые значения");
                Console.ReadKey();
            }
        }
    }
}
