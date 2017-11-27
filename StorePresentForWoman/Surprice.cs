using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePresentForWoman
{
    class Surprice : Present
    {
        public string TimeBeginning { get; private set; }

        public Surprice(string name, string timebeginning, int price)
        {
            Name = name;
            TimeBeginning = timebeginning;
            Price = price;
        }
    }
}
