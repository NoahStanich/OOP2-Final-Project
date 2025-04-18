using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2FinalProjectTest
{
    public class Seasonal : Menu
    {
        public string season {  get; set; }
        public DateTime validUntil { get; set; }

        public void ApplyDiscount()
        {
            if (season == "Fall")
            {
                price = price * 0.8;
            }
            else if (season == "Winter")
            {
                price = price * 0.5;
            }
            else if (season == "Summer")
            {
                price = price * 0.2;
            }
        }
    }
}
