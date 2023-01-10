using CustomerReward.Entities;
using CustomerReward.Repository.Interfaces;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerReward.TestCase
{
    public class RewardTest
    {
        private readonly IRewardRepo _rewardRepo;

        public RewardTest(IRewardRepo rewardRepo)
        {
            _rewardRepo = rewardRepo;
        }

        [Test]
        public Reward RewardData()
        {
            Reward _reward = new Reward();
            _reward.CustomerId = 111;
            _reward.LastMonthReward = 113;
            _reward.LastSecondMonthReward = 223;
            _reward.LastThirdMonthReward = 432;
            _reward.TotalRewards = 543;
            return _reward;
        }

        [Test]
        public void TestReward()
        {
            var result = _rewardRepo.GetRewardsByCustomerId(111);
            Assert.Equals(result, RewardData());
        }
    }
}
