using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        public static void Reverse(int[] massiv)
        {
            for (int i = 0; i < massiv.Length; i++)

            {
                if (massiv[i] > 0)
                {
                    massiv[i] = -1 * massiv[i];
                }
            }
        }

            static void Main(string[] args)
            {
                int[] array = new int[5] { 1, 2, 3, 4, 5 };
                Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
                Console.ReadKey();
            }
        }
    }

