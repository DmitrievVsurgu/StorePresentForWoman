using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePresentForWoman
{
    public class Informer
    {
        public void Buy(User user, Present present)
        {
            double price = present.GetDiscountPrice(user);
            user.ReduceBalance(price);
            Console.WriteLine($"{user.Name} купил {present.Name} за {price}. Заказ отпрвлен на склад");
        }
    }
}
