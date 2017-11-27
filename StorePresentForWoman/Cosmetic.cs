using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePresentForWoman
{
    class Cosmetic : Present
    {
        public string Color { get; private set; }
        public string Firma { get; private set; }

        public Cosmetic(string name, int price, string color, string firma, string manufacture)
        {
            Name = name;
            Price = price;
            Color = color;
            Firma = firma;
            Manufacture = manufacture;
        }

        public override double GetDiscountPrice(User user)
        {
        }
    }
}
