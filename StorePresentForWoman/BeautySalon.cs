using System;

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
        public override double GetDiscountPrice(User user)
        {
            Service = Service.ToLower();
            if (user.DayOfTheWeek == "WEDNESDAY" && Service[0] == 'm')
            {
                return Price * 0.85;
            }
            if(Service[0] == 'r')
            {
                return Price * 0.9;
            }
            return Price;
        }
        public override void GetWrite()
        {
            Console.WriteLine("BeautySalon:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Service: " + Service);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine();
        }
    }
}
