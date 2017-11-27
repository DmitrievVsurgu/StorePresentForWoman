using System;

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
        public override double GetDiscountPrice(User user)
        {
            Name = Name.ToLower();
            if (user.DayOfTheWeek == "monday" && Name[0] == 'm')
            {
                return Price * 0.9;
            }
            return Price;
        }
        public override void GetWrite()
        {
            Console.WriteLine("Surprice:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("TimeBeginning: " + TimeBeginning);
            Console.WriteLine();
        }
    }
}
