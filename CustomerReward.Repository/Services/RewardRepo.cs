using CustomerReward.Entities;
using CustomerReward.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CustomerReward.Repository.Helper;

namespace CustomerReward.Repository.Services
{
    public class RewardRepo : IRewardRepo
    {
		private readonly ITransactionRepo _transactionRepo;
 
		public RewardRepo(ITransactionRepo transactionRepo)
        {
			_transactionRepo = transactionRepo;
        }
	
		public async Task<Reward> GetRewardsByCustomerId(long customerId)
		{

			DateTime lastMonthDate = GetDays(Constant.monthDays);
			DateTime secondMonthDate = GetDays(2 * Constant.firstReward);
			DateTime thirdMonthDate = GetDays(3 * Constant.secondReward);

			List<Transaction> lastMonthTransactions =await _transactionRepo.GetCustomersByIdAndTransactionDate(
					customerId, lastMonthDate, DateTime.Now);
			List<Transaction> secondMonthTransactions = await _transactionRepo
					.GetCustomersByIdAndTransactionDate(customerId, secondMonthDate, lastMonthDate);
			List<Transaction> thirdMonthTransactions = await _transactionRepo
					.GetCustomersByIdAndTransactionDate(customerId, thirdMonthDate,
							secondMonthDate);

			Reward customerRewards = new Reward();
			customerRewards.CustomerId = customerId;
			customerRewards.LastThirdMonthReward = GetRewardsPerMonth(lastMonthTransactions); ;
			customerRewards.LastSecondMonthReward = GetRewardsPerMonth(secondMonthTransactions); ;
			customerRewards.LastThirdMonthReward = GetRewardsPerMonth(thirdMonthTransactions); ;
			customerRewards.TotalRewards = customerRewards.LastThirdMonthReward + customerRewards.LastSecondMonthReward + customerRewards.LastThirdMonthReward;

			return customerRewards;

		}

		private long GetRewardsPerMonth(List<Transaction> transactions)
		{
			var reward = 0.0D;
			foreach (Transaction transaction in transactions)
			{
				reward += CalculateRewards(transaction);
			}
			return (long)reward;
		}

		private double CalculateRewards(Transaction t)
		{
			if (t.getTransactionAmount() > Constant.firstReward && t.getTransactionAmount() <= Constant.secondReward)
			{
				return Math.Round(t.getTransactionAmount() - Constant.firstReward);
			}
			else if (t.getTransactionAmount() > Constant.secondReward)
			{
				return Math.Round(t.getTransactionAmount() - Constant.secondReward) * 2
						+ (Constant.secondReward - Constant.firstReward);
			}
			else
				return 0;

		}

		public DateTime GetDays(int days)
		{
			return DateTime.Now.AddDays(-days);
		}
    }
}
