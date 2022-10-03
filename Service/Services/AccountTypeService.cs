using BLL.DTO.AccountType;
using BLL.Mappers;
using BLL.Interfaces;
using Core.Abstraction.DataAccess;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AccountTypeService : IAccountTypeService
    {

        private readonly IAccountTypeRepository _accountTypeRepo;

        public AccountTypeService(IAccountTypeRepository accountTypeRepo)
        {
            _accountTypeRepo = accountTypeRepo;
        }

        public void Add(CreateAccountTypeModel model)
        {
            _accountTypeRepo.Add(model.MapToAccountTypeModel);
        }

        public void Delete(int id)
        {
            _accountTypeRepo.Delete(id);
        }

        public GetAccountTypeModel Get(int id)
        {
            return _accountTypeRepo.Get(id).MapToGetAccountTypeModel();

        }

        public void Update(UpdateAccountTypeModel model)
        {
            _accountTypeRepo.Update(model.MapToAccountType());

        }



    }  
        
        
         
}    
