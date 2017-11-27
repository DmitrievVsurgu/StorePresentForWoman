using System;

namespace StorePresentForWoman
{
    class Cosmetic : Present
    {
        public string Color { get; private set; }
        public string Firma { get; private set; }

        public Cosmetic(string name, int price, string color, string firma)
        {
            Name = name;
            Price = price;
            Color = color;
            Firma = firma.ToLower();

        }

        public override double GetDiscountPrice(User user)
        {
            if(user.DateDay == 8 && Firma[0] == 'a')
            {
                return Price * 0.85;
            }
            return Price;
        }
        public override void GetWrite()
        {
            Console.WriteLine("Surprice:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Firma: " + Firma);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine();
        }
    }
}
