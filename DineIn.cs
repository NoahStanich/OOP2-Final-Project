using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2FinalProjectTest
{
    public class DineIn : ITransaction
    {
        public int transactionId {  get; set; }
        public DateTime date { get; set; }
        public int orderId { get; set; }
        public int tableId { get; set; }

        public int CalculateTotal(int orderId)
        {
            throw new NotImplementedException();
        }

        public void ValidateTransaction()
        {
            throw new NotImplementedException();
        }

        public void ApplyCharge()
        {

        }
    }
}
