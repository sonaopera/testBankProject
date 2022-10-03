using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstraction.DataAccess
{
    public interface IAccountRepository : IBaseRepository<Account>
    {
        List<Account> Get (string AccountNumber, int? TypeId, decimal? Balances, int? CurrencyId, int skipCount = 0, int takeCount = 100);
        
        
    }
}
