using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
            Console.WriteLine("Введите n");
           int n = Convert.ToInt32(Console.ReadLine());//n - верхняя граница массива
            double[,] a = new double[n,n];// Инициализация массива
            double[] b = new double[10];// Инициализация массива
                double[] c = new double[10];// Инициализация массива
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine("Введите элементы массива a");
                        a[i, j] = Convert.ToDouble(Console.ReadLine());//Вводим элементы массива
                    }
                }
                for (int k = 0; k < 10; k++)
                {
                    Console.WriteLine("Введите элементы массива b");
                    b[k] = Convert.ToDouble(Console.ReadLine());//Вводим k-е элементы массива
                }
                for (int k = 0; k < 10; k++)
                {
                    Console.WriteLine("Введите элементы массива c");
                    c[k] = Convert.ToDouble(Console.ReadLine());//Вводим k-е элементы массива
                }
                double sum_1 = 0, sum_2 = 0;//Инициализация суммы для числителя и знаменателя
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        sum_1 += Math.Abs(Math.Pow(a[i, j], 2) + Math.Pow(a[j, i], 2));//Находим сумму числителя
                    }
                    for (int k = 0; k < 10; k++)
                    {
                        sum_2 += Math.Sin(b[k]) + Math.Cos(c[k] * c[k]);//Находим сумму знаменателя
                    }
                }
                Console.WriteLine("Cумма равна: " + (sum_1 / sum_2));//Вывод конечной суммы
                Console.WriteLine("Нажмите любую клавишу для выхода");
                Console.ReadKey();
            }
            catch(FormatException)//Обработка исключения связанного с форматом вводимых значений
            {
                Console.WriteLine("Вы ввели не число");
                Console.WriteLine("Нажмите любую клавишу для выхода");
                Console.ReadKey();
            }
        }
    }
}
