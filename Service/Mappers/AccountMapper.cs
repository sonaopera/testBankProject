using BLL.DTO.Account;
using Service.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers;

public static class AccountMapper
{
    public static List<GetAccountModel> MapToGetAccountModel(this IEnumerable<Account> account)
    {
        return account.Select(x => x.MapToGetAccountModel()).ToList();

    }

    public static Account MapToAccountModel(this CreateAccountModel createAccount)
    {
        return new Account
        {
            AccountNumber = createAccount.AccountNumber,
            Balances = 0,
            CurrencyId = createAccount.CurrencyId,
            TypeId = createAccount.TypeId

        };



    }

    public static GetAccountModel MapToGetAccountModel(this Account account)
    {
        return new GetAccountModel
        {
            Id = account.Id,
            Balances = account.Balances,
            AccountNumber = account.AccountNumber,
            CurrencyId = account.CurrencyId,
            TypeId = account.TypeId,
        };



    }

    public static Account MapToAccountModel(this UpdateAccountModel updateAccount)
    {
        return new Account
        {
            Id = updateAccount.Id,
            TypeId = updateAccount.TypeId




        };


    }

}
