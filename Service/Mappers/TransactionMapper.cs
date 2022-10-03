using BLL.DTO.Transaction;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public static class TransactionMapper
    {
        public static Transaction MapToTransaction(this CreateTransactionModel createTransaction)
        {
            return new Transaction
            {
                AccountId = createTransaction.AccountId,
                Amount = createTransaction.Amount,
                Date = createTransaction.Date
            };
        }
        public static List<GetTransactionModel> MapToGetTransactionModel(this IEnumerable<Transaction> transaction)
        {
            return transaction.Select(x => x.MapToGetTransactionModel()).ToList();

        }

        public static GetTransactionModel MapToGetTransactionModel(this Transaction transaction)
        {
            return new GetTransactionModel
            {
               Id = transaction.Id,
               AccountId = transaction.AccountId,
               Amount = transaction.Amount,
               Date = transaction.Date
               

            };



        }
        public static Transaction MapToTransaction(this UpdateTransactionModel updateTransaction)
        {
            return new Transaction
            {
                Id = updateTransaction.Id,
                AccountId = updateTransaction.AccountId,
                Amount = updateTransaction.Amount,
                Date = updateTransaction.Date

            };


        }




    }
}
