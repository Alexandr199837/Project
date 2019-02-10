using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dairy
{
    [Serializable]
    public class Data
    {
        public string First { get; set; }

        public bool Check { get; set; }

        public string Date { get; set; }
        public List<Data> l = new List<Data>();
    }
}
