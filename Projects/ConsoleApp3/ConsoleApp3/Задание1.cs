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
                int N = Input("количество сторон:"); //Вводим количество сторон.
                int Radius = InputRadius("радиус:"); //Вводим радиус
                double S = Math.Tan(Math.PI / N) * Math.Pow(Radius, 2) * N;//Вычисляем площадь
                Console.WriteLine((N < 3) ? "У многоугольника минимум 3 стороны.Будьте внимательнее!" : "Площадь фигуры равна:" + S);
                ProgExit(0);
                Console.ReadKey();
            }
            catch (FormatException)
            {
                PrintResult("Вы ввели не число");              
            }
            catch (OverflowException)
            {
                PrintResult("Ошибка:");
            }
        }

        private static int InputRadius(string mess)
        {
            Console.Write("Введите {0} ", mess);
            string _temp = Console.ReadLine();
            if (_temp.Trim().ToLower().Equals("exit"))
                ProgExit(1);
            return Convert.ToInt32(_temp);
        }

        private static int Input(string mess)
        {
            Console.Write("Введите {0} ", mess);
            string _temp = Console.ReadLine();
            if (_temp.Trim().ToLower().Equals("exit"))
                ProgExit(1);

            return Convert.ToInt32(_temp);
        }

        private static void ProgExit(int e)
        {
            Console.Write("Press any key to exit ... ");
            Console.ReadKey();
            Environment.Exit(e);
        }

        private static void PrintResult(string mess)
        {
            Console.WriteLine(mess);
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
