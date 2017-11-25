using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePresentForWoman
{
    public class Flowers : Present
    {
        public string Color { get; private set; }
        public int Count { get; private set; }

        public Flowers(string name, int price, string color, int count)
        {
            Name = name;
            Price = price;
            Color = color;
            Count = count;
        }

        public override double GetDiscountPrice(User user)
        {
            return ;
        }
    }
}
