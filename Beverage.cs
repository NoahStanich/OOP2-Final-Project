using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2FinalProjectTest
{
    public class Beverage : Menu
    {
        public bool IsAlcoholic(int itemId)
        {
            return itemId > 0;
        }
    }
}
