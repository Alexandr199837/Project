using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace авто
{
    class Program
    {
        static void Main(string[] args)
        {
      
            Automobile _porsche = new Automobile() { Color = "Red", Speed = 290};//Используем ранее созданный класс.
            Automobile _chevrolet = new Automobile() { Color ="Black", Speed =210};//Используем ранее созданный класс.
            _porsche.Model = "Panamera";
            _chevrolet.Model = "Tahoe";
            Console.WriteLine(_porsche.Model);
            Console.WriteLine(_chevrolet.Color);
            Console.ReadKey();
            
            
        }
    }
}
