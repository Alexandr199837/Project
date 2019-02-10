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
                double X = Input("X"); //Вводим координаты X.
                double Y = Input("Y");//Вводим координаты Y.
                Console.WriteLine(((Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2)) <= 2) && (Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2)) >= 1) && (Y > 0)) ? "Точка попадает в закрашенную область" : "Точка не попадает в закрашенную область");
                ProgExit(0);
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не числовые значения");
                Console.ReadKey();
            }
        }

        private static double Input(string mess)
        {
            do
            {
                try
                {
                    Console.Write("Введите координаты {0}: ", mess);
            string _temp = Console.ReadLine();
            if (_temp.Trim().ToLower().Equals("exit"))
                ProgExit(1);
            return Convert.ToDouble(_temp);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат числа при вводе значения {0}. Введите значение {0} повторно.", mess);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Введенное значение {0} слишком большое. Введите значение {0} повторно.", mess);
                }
            } while (true);
        }

        private static void ProgExit(int e)
        {
            Console.Write("Press any key to exit ... ");
            Console.ReadKey();
            Environment.Exit(e);
        }
    }
}
   