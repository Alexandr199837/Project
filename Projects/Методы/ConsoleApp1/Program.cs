using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TV
    {
        public int NumberChannel;
        public void ChannelSwitch(int a)
        {
            NumberChannel = a;
        }
        public void ChannelUp()
        {
            if (NumberChannel < 200)
                NumberChannel++;
        }
        public void ChannelDown()
        {
            if (NumberChannel > 0)
                NumberChannel--;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            TV Samsung = new TV();
            Samsung.ChannelSwitch(0);
            Samsung.ChannelDown();
            Console.WriteLine(Samsung.NumberChannel);
            Console.ReadKey();

        }
    }
}
