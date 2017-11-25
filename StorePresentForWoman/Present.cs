using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePresentForWoman
{
    class Present
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Manufacture { get; set; }

        public virtual double GetDiscountPrice(User user)
        {
            if(user.DateDay == )
            {

            }
            if ()
            {

            }
            return Price ;
        }
    }
}
