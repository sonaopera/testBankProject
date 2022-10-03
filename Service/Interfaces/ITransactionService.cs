using BLL.DTO.Transaction;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ITransactionService 
    {
        void Add(CreateTransactionModel model);
        void Delete(int id);
        void Update(UpdateTransactionModel model);
        List<GetTransactionModel> Get(DateOnly? Dates, decimal? Amouts, int? AccountId, int skipCount , int takeCount );
    }
}
