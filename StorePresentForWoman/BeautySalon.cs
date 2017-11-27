using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePresentForWoman
{
    class BeautySalon : Present
    {
        public string Service { get; private set; }

        public BeautySalon(string name, int price, string service)
        {
            Name = name;
            Price = price;
            Service = service;

        }
    }
}
