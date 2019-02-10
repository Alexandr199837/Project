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
            List<string> teams = new List<string>();
            teams.Add("Barcelona");
            teams.Add("Chelsea");
            teams.Add("Arsenal");
            List<string> teams2 = new List<string>() { "Dynamo", "CSKA" };
            Console.WriteLine(teams);
            Console.ReadKey();
        }
    }
}
