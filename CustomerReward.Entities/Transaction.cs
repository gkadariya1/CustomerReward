using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerReward.Entities
{
    public class Transaction
    {
        public long Id { get; set; }

        public long CustomerId { get; set; }

        public DateTime TransDate { get; set; }

        public double TransAmount { get; set; }

        public double getTransactionAmount()
        {
            return TransAmount;
        }

    }
}
