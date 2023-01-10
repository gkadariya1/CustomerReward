using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerReward.Entities
{
    public class Reward
    {
        public long CustomerId { get; set; }
        public decimal LastMonthReward { get; set; }
        public decimal LastSecondMonthReward { get; set; }
        public decimal LastThirdMonthReward { get; set; }
        public decimal TotalRewards { get; set; }
    }
}
