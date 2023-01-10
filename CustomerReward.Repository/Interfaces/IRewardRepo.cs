using CustomerReward.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CustomerReward.Repository.Interfaces
{
    public interface IRewardRepo
    {
        Task<Reward> GetRewardsByCustomerId(long customerId);
    }
}
