using CustomerReward.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CustomerReward.Repository.Interfaces
{
    public interface ITransactionRepo
    {
        Task<List<Transaction>> GetCustomersById(long customerId);
        Task<List<Transaction>> GetCustomersByIdAndTransactionDate(long customerId, DateTime from, DateTime to);
    }
}
