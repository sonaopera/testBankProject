using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstraction.DataAccess
{
    public  interface ITransactionRepository : IBaseRepository<Transaction>
    {
        List<Transaction> Get(DateOnly? Dates, decimal? Amouts, int? AccountId, int skipCount = 0, int takeCount = 100);
        
    }
}
