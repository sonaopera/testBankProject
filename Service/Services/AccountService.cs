using BLL.DTO.Account;
using BLL.Interfaces;
using BLL.Mappers;
using Core.Abstraction.DataAccess;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepo;

        public AccountService(IAccountRepository accountRepo)
        {
            _accountRepo = accountRepo;
        }


        public void Add(CreateAccountModel model)
        {
            _accountRepo.Add(model.MapToAccountModel());
        }

      
        public void Delete(int id)
        {
            _accountRepo.Delete(id);
        }

        List<GetAccountModel> IAccountService.Get(string AccountNumber, int? TypeId, decimal? Balances, int? CurrencyId, int skipCount, int takeCount)
        {
            return _accountRepo.Get(AccountNumber, TypeId, Balances, CurrencyId, skipCount, takeCount).MapToGetAccountModel();
        }

        public GetAccountModel Get(int id)
        {
            return _accountRepo.Get(id).MapToGetAccountModel();
        }

       

        public  void Update(UpdateAccountModel model)
        {
            _accountRepo.Update(model.MapToAccountModel());
        }

        
    }
}
