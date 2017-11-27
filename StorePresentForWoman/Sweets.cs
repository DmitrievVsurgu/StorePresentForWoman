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
        public override double GetDiscountPrice(User user)
        {
            TypeSweets = TypeSweets.ToLower();
            if (user.DayOfTheWeek == "Friday" && TypeSweets == "chocolate")
            {
                return Price * 0.5;
            }
            if (user.DateDay == 8 && TypeSweets == "candy")
            {
                return Price * 0.7;
            }
            return Price;
        }
        public override void GetWrite()
        {
            Console.WriteLine("Sweets:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("TypeSweets: " + TypeSweets);
            Console.WriteLine("Filler: " + Filler);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine();
        }
    }
}
