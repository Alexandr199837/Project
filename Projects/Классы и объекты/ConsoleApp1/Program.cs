using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Automobile
    {
        public string FirstName;
        internal string LastName;
        public int Age;
        public string Group;
    }
      class Program
    {
        static void Main(string[] args)
        {
            Automobile Auto1 = new Automobile();
            Automobile Auto2 = new Automobile();
            Auto1.Group = "Audi";
            Auto2.Group = "BMW";
            Auto1.FirstName = "A6";
            Console.WriteLine(Auto1.Group);
            Console.WriteLine(Auto2.Group);
            Console.ReadKey();
        }
    
        
        
        }
    }

