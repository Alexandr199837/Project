using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                int m, n, i, j, sum = 0; //Инициализация переменных
                m = Input("m");//Ввод грниц рамок массива
                n = Input("n");//Ввод грниц рамок массива
                if ((m < 0) || (n < 0))// Проверка размера массива 
                {
                    PrintResult("Ошибка");
                }
                else
                {
                    int[,] Z = new int[m, n];//Инициализация массива
                    for (i = 0; i < m; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.WriteLine("Введите элементы массива");
                            Z[i, j] = Convert.ToInt32(Console.ReadLine());//Ввод элементов массива
                        }
                    }
                    for (i = 0; i < m; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            if (Z[i, j] > 0)
                                sum += Z[i, j];//Нахождение суммы положительных элементов массива
                        }
                    }
                    double tng = Tangens(sum);
                    Console.WriteLine("Тангенс равен: " + tng);
                    Console.ReadKey();
                    ProgExit(0);
                }
            }
            catch (FormatException)//Обработка исключений ввода
            {
                PrintResult("Вы ввели не число");
            }
        }

        private static int Input(string mess)
        {
            Console.WriteLine("Введите {0}", mess);
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

        private static void PrintResult(string mess)//Метод для вывода сообщения о выходе
        {
            Console.WriteLine(mess);
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();        
        }
        private static double Tangens(int sum)//Метод для нахождения тангенса
        {
            return Math.Tan(sum);
        }
    }
    }
   




