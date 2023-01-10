using CustomerReward.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CustomerReward.Repository.Data
{
    public class TransactionData
    {
        public static async Task<List<Transaction>> GetTransactionData()
        {
            List<Transaction> transactionList = new List<Transaction>();
            transactionList.Add(new Transaction() { Id = 1, CustomerId = 111, TransAmount = 120.00, TransDate = new DateTime(2022, 10, 12) });
            transactionList.Add(new Transaction() { Id = 2, CustomerId = 112, TransAmount = 210.00, TransDate = new DateTime(2023, 01, 01) });
            transactionList.Add(new Transaction() { Id = 3, CustomerId = 113, TransAmount = 320.00, TransDate = new DateTime(2023, 01, 02) });
            transactionList.Add(new Transaction() { Id = 4, CustomerId = 114, TransAmount = 430.00, TransDate = new DateTime(2023, 01, 03) });
            transactionList.Add(new Transaction() { Id = 5, CustomerId = 115, TransAmount = 540.00, TransDate = new DateTime(2023, 01, 02) });
            transactionList.Add(new Transaction() { Id = 6, CustomerId = 116, TransAmount = 140.00, TransDate = new DateTime(2023, 01, 01) });
            transactionList.Add(new Transaction() { Id = 7, CustomerId = 117, TransAmount = 250.00, TransDate = new DateTime(2023, 01, 01) });
            transactionList.Add(new Transaction() { Id = 8, CustomerId = 118, TransAmount = 370.00, TransDate = new DateTime(2023, 01, 02) });
            transactionList.Add(new Transaction() { Id = 9, CustomerId = 111, TransAmount = 460.00, TransDate = new DateTime(2023, 01, 03) });
            transactionList.Add(new Transaction() { Id = 10, CustomerId = 111, TransAmount = 540.00, TransDate = new DateTime(2022, 01, 02) });
            transactionList.Add(new Transaction() { Id = 11, CustomerId = 112, TransAmount = 130.00, TransDate = new DateTime(2022, 12, 09) });
            transactionList.Add(new Transaction() { Id = 12, CustomerId = 113, TransAmount = 220.00, TransDate = new DateTime(2023, 01, 01) });
            transactionList.Add(new Transaction() { Id = 13, CustomerId = 114, TransAmount = 330.00, TransDate = new DateTime(2022, 09, 02) });
            transactionList.Add(new Transaction() { Id = 14, CustomerId = 115, TransAmount = 430.00, TransDate = new DateTime(2023, 01, 03) });
            transactionList.Add(new Transaction() { Id = 15, CustomerId = 116, TransAmount = 500.00, TransDate = new DateTime(2022, 10, 12) });
            transactionList.Add(new Transaction() { Id = 16, CustomerId = 117, TransAmount = 100.00, TransDate = new DateTime(2022, 11, 09) });
            transactionList.Add(new Transaction() { Id = 17, CustomerId = 118, TransAmount = 200.00, TransDate = new DateTime(2023, 01, 01) });
            transactionList.Add(new Transaction() { Id = 18, CustomerId = 116, TransAmount = 300.00, TransDate = new DateTime(2023, 01, 02) });
            transactionList.Add(new Transaction() { Id = 19, CustomerId = 112, TransAmount = 400.00, TransDate = new DateTime(2022, 12, 11) });
            transactionList.Add(new Transaction() { Id = 20, CustomerId = 113, TransAmount = 500.00, TransDate = new DateTime(2022, 10, 12) });
            await Task.Delay(1000);
            return transactionList;
        }
    }
}
