using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Programm
    {
        /// <summary>
        /// Ввод и обработка различных команд для параметров.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            foreach (string s in args)
            {
                if (args.Length != 0)
                {
                    if (args.Length > 1)
                    {
                        Условия(args);
                        Console.ReadKey();
                        if (args[1] == "2")
                        {
                            string[] _lines = File.ReadLines("H:\\123.txt").ToArray();
                            double res = 0;
                            for (int i = 0; i < _lines.Length; i++)
                            {
                                if (double.TryParse(_lines[i], out res))
                                {
                                    _lines[i] = res.ToString();
                                }
                            }
                            File.WriteAllLines("H:\\123.txt", _lines);
                        }
                    }
                    else
                    {
                        Условия(args);
                        Console.ReadKey();
                    }
                }
                else
                    Console.WriteLine("Значения не предусмотрены");

                

            }
        }

        private static void Условия(string[] args)
        {
            if (args[0] == "Привет")
            {
                Console.WriteLine("Здравствуй");
            }

            if (args[0] == "Пока")
            {
                Console.WriteLine("До свидания");
            }
            if (args[0] == "1")
                Console.WriteLine("{0}{1}", args[0], 10 * Convert.ToInt32(args[0]));
        }
    }
}
