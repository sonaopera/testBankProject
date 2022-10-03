using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.AccountType
{
    public class CreateAccountTypeModel
    {
        public string Name { get; set; }
        public Core.Models.AccountType MapToAccountTypeModel { get; internal set; }
    }
}
