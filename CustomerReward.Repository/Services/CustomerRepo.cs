using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CustomerReward.Entities;
using CustomerReward.Repository.Interfaces;
using System.Linq;

namespace CustomerReward.Repository.Services
{
    public class CustomerRepo : ICustomerRepo
    {
		public async Task<IEnumerable<Customer>> GetCustomerList()
		{
			var customers=await Data.CustomerData.GetCustomerList();
			return  customers as IEnumerable<Customer>;
		}

		public async Task<Customer> GetCustomerById(long customerId)
		{
			var customers= await Data.CustomerData.GetCustomerList();
			return customers.Find(x=>x.Id==customerId);
		}
	}
}
