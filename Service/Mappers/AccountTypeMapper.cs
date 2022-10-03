using BLL.DTO.AccountType;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public static class AccountTypeMapper
    {
        public static AccountType MapToAccountType(this CreateAccountTypeModel createAccountType)
        {
            return new AccountType
            {
                Names = createAccountType.Name,
            };
        }

        public static AccountType MapToAccountType(this UpdateAccountTypeModel updateAccountType)
        {
            return new AccountType

            {
                Id = updateAccountType.Id,
                Names = updateAccountType.Name,

            };
        }


        public static GetAccountTypeModel MapToGetAccountTypeModel(this AccountType accountType)
        {
            return new GetAccountTypeModel
            {
                Id = accountType.Id,
                Names = accountType.Names

            };
        }

        
    }




}



