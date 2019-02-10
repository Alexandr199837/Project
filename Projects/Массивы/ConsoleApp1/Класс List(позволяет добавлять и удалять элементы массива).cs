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
            List<string> teams = new List<string>() { "Juventus", "Milan", "Bayern", "Inter" };
            teams.Insert(2, "Barcelona");// вставляем в список элемент "Barcelona" на позицию 2
            teams.Remove("Milan"); // удаляем первое вхождение элемента "Milan" из списка 
            List<string> NewTeams = new List<string>() { "Liverpool", "Roma", "Borussia", "Valencia" };
            teams.AddRange(NewTeams);// добавляем в конец списка элементы списка newTeams
            Console.ReadKey();
        }
    }
}
