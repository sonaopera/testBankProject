using BLL.DTO.Transaction;
using BLL.Interfaces;
using BLL.Mappers;
using Core.Abstraction.DataAccess;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class TransactionService : ITransactionService
    {

        private readonly ITransactionRepository _transactionRepo;

        public TransactionService(ITransactionRepository transactionRepo)
        {
            _transactionRepo = transactionRepo;
        }



        public void Add(CreateTransactionModel model)
        {
            _transactionRepo.Add(model.MapToTransactionModel);
        }

        public void Delete(int id)
        {
            _transactionRepo.Delete(id);
        }

        public GetTransactionModel Get(int id)
        {
            return _transactionRepo.Get(id).MapToGetTransactionModel();

        }

        public void Update(UpdateTransactionModel model)
        {
            _transactionRepo.Update(model.MapToTransaction());
        }

        public List<GetTransactionModel> Get(DateOnly? Dates, decimal? Amouts, int? AccountId, int skipCount, int takeCount)
        {
            return _transactionRepo.Get(Dates, Amouts, AccountId, skipCount, takeCount).MapToGetTransactionModel();
        }
    }
}
