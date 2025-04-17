using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Final_Project.Components.Pages
{
    public interface ITransaction
    {
        public int transactionId { get; set; }
        public DateTime date { get; set; }  
        public int orderId { get; set; }
        public int CalculateTotal(int orderId);
        public void ValidateTransaction();
    }
}
