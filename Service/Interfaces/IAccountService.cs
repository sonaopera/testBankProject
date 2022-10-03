using BLL.DTO.Account;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IAccountService 
    {
        void Add(CreateAccountModel model);
        void Delete(int id);
        void Update(UpdateAccountModel model);
        List<GetAccountModel> Get(string AccountNumber, int? TypeId, decimal? Balances, int? CurrencyId, int skipCount , int takeCount );
    }
}
