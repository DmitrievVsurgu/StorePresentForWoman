using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePresentForWoman
{
    class Sweets : Present
    {
        public string TypeSweets { get; private set; }
        public string Filler { get; private set; }

        public Sweets(string typesweets, string name, string filler, int price)
        {
            TypeSweets = typesweets;
            Name = name;
            Filler = filler;
            Price = price;
        }
    }
}
