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
            string result;
            try
            { int summa;
                int[] massiv = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                for (int i = 0; i < massiv.Length; i++)
                { int chislo;
                    chislo = massiv[i];
                    Console.WriteLine(chislo);
                }
                Console.WriteLine("Введите первое число");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                int b = Convert.ToInt32(Console.ReadLine());
                summa = massiv[a] + massiv[b];
                Console.WriteLine(summa);
                Console.ReadKey();
            }
            catch (FormatException)
            { result = "Вы ввели не число";
                Console.WriteLine(result);
                Console.ReadKey();
            }
            catch (IndexOutOfRangeException)
            { result = "Индекс вне рамок массива";
                Console.WriteLine(result);
                Console.ReadKey();
            }
            }
        }
    } 
