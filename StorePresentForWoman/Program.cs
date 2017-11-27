using System;

namespace StorePresentForWoman
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(
                "Vasay",
                "Kosmonavtov street, 53 home",
                8,
                "Monday",
                5000,
                1000
                );

            Console.WriteLine("List products: ");
            Console.WriteLine();

            Flowers roses = new Flowers(
                "Rose",
                600,
                "Yelow",
                4
                );
            Flowers tulip = new Flowers(
                "Tylip",
                600,
                "Red",
                6
                );
            Flowers chrysanthemum = new Flowers(
                "Сhrysanthemum",
                600,
                "Orange",
                3
                );

            roses.GetWrite();
            tulip.GetWrite();
            chrysanthemum.GetWrite();

            Sweets chocolate = new Sweets(
                "Chocolate",
                "Alpen gold",
                "nuts",
                100
                );
            Sweets candy = new Sweets(
                "Candy",
                "Korkunov",
                "Cream",
                200
                );
            Sweets marmalade = new Sweets(
                "Marmalade",
                "Fruit-tella",
                "Gelatin",
                100
                );

            chocolate.GetWrite();
            candy.GetWrite();
            marmalade.GetWrite();

            Cosmetic lipstick = new Cosmetic(
                "Lipstick",
                250,
                "Pink",
                "Avon"
                );
            Cosmetic perfum = new Cosmetic(
                "Perfum",
                900,
                "White",
                "Coco Shanel"
                );
            Cosmetic mascara = new Cosmetic(
                "Mascara",
                430,
                "Black",
                "MaxFactor"
                );

            lipstick.GetWrite();
            perfum.GetWrite();
            mascara.GetWrite();

            Surprice movie = new Surprice(
                "Movie",
                "18:40",
                330
                );
            Surprice restaurant = new Surprice(
                "Restaurant",
                "20:00",
                3000
                );
            Surprice theatre = new Surprice(
                "Theatre",
                "19:20",
                530
                );

            movie.GetWrite();
            restaurant.GetWrite();
            theatre.GetWrite();

            BeautySalon schwarzkopf = new BeautySalon(
                "Schwarzkopf",
                1500,
                "Massage"
                );
            BeautySalon shadestyle = new BeautySalon(
                "Shade & Style",
                700,
                "Manicure"
                );
            BeautySalon allegany = new BeautySalon(
                "Allegany",
                2000,
                "SPA"
                );

            schwarzkopf.GetWrite();
            shadestyle.GetWrite();
            allegany.GetWrite();

            Present[] presents = new Present[]
            {
                roses, tulip, chrysanthemum,
                chocolate, candy, marmalade,
                movie, restaurant, theatre,
                lipstick, perfum, mascara,
                schwarzkopf, shadestyle, allegany
            };

            Informer informer = new Informer();

            while(true)
            {
                Console.WriteLine();
                Console.WriteLine($"Hello {user.Name} your balance {user.Balance}");
                Console.WriteLine();

                for (int i = 0; i < presents.Length; i++)
                {
                    Console.WriteLine($"Present {i} {presents[i].Name} to price {presents[i].Price}");
                }
                Console.Write("Select the item and press Enter:");

                string str = Console.ReadLine();
                int productNumber = Convert.ToInt32(str);
                if (productNumber >= 0 && productNumber < presents.Length)
                {
                    if (presents[productNumber].Price < user.Balance)
                    {
                        informer.Buy(user, presents[productNumber]);
                    }
                    else
                    {
                        Console.WriteLine("You have incufficient funds");
                    }
                }
                else
                {
                    Console.WriteLine("This present is no longer");
                }
            }
        }
    }
}
