using BLL.DTO.AccountType;
using BLL.Services;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IAccountTypeService 
    {
        void Add(CreateAccountTypeModel model);
        GetAccountTypeModel Get(int id);
        void Update(UpdateAccountTypeModel model);
        void Delete(int id);
    }
}
