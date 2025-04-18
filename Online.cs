using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Final_Project.Components.Pages
{
    public class Online : ITransaction
    {
        public int transactionId { get; set; }
        public DateTime date { get; set; }
        public int orderId { get; set; }

        public double CalculateDeliveryFee()
        {
            return 0;
        }

        public int CalculateTotal(int orderId)
        {
            throw new NotImplementedException();
        }

        public void ValidateTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
