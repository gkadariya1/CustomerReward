using CustomerReward.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CustomerReward.Repository.Data
{
    public class CustomerData
    {
        public static async Task<List<Customer>> GetCustomerList()
        {
            List<Customer> customers_list = new List<Customer>();
            customers_list.Add(new Customer() { Id = 111, Name = "Customer1" });
            customers_list.Add(new Customer() { Id = 112, Name = "Customer2" });
            customers_list.Add(new Customer() { Id = 113, Name = "Customer3" });
            customers_list.Add(new Customer() { Id = 114, Name = "Customer4" });
            customers_list.Add(new Customer() { Id = 115, Name = "Customer5" });
            customers_list.Add(new Customer() { Id = 116, Name = "Customer6" });
            customers_list.Add(new Customer() { Id = 117, Name = "Customer7" });
            customers_list.Add(new Customer() { Id = 118, Name = "Customer8" });
            await Task.Delay(1000);
            return customers_list;
        }
    }
}
