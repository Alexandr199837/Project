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


                int m,n, i, j, sum = 0; //Инициализация переменных
                Console.WriteLine("Введите m");
                m = Convert.ToInt32(Console.ReadLine());//Ввод грниц рамок массива
                Console.WriteLine("Введите n");
                n = Convert.ToInt32(Console.ReadLine());//Ввод грниц рамок массива
                if ((m < 0) || (n < 0))// Проверка размера массива 
                {
                    Console.WriteLine("Ошибка");
                    PrintResult();
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
                }
            }
            catch (FormatException)//Обработка исключений ввода
            {
                Console.WriteLine("Вы ввели не число");
                Console.WriteLine("Нажмите любую клавишу для выхода");
                Console.ReadKey();
            }
        
        }

        private static void PrintResult()
        {
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();
        }

        private static double Tangens(int sum)//Метод для нахождения тангенса
        {
            return Math.Tan(sum);
        }
    }
    }
   




