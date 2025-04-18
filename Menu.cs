using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Final_Project.Components.Pages
{
    public class Menu
    {
        public int itemId { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int inventory { get; set; }
        
        public bool IsAvailable(int quantity)
        {
            if (quantity > inventory)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
