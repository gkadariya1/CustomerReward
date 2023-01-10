using CustomerReward.Entities;
using CustomerReward.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerReward.Repository.Services
{
    public class TransactionRepo :ITransactionRepo
    {
        public async Task<List<Transaction>> GetCustomersById(long customerId)
        {
            var trans= await Data.TransactionData.GetTransactionData();
            return trans.Where(x => x.CustomerId == customerId).ToList();
        }

        public async Task<List<Transaction>> GetCustomersByIdAndTransactionDate(long customerId, DateTime from, DateTime to)
        {
            var trans= await Data.TransactionData.GetTransactionData();
            return trans.Where(x => x.CustomerId == customerId && x.TransDate >= from && x.TransDate <= to).ToList();
        }
    }
}
