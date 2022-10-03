using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.Account
{
    public class CreateAccountModel
    {
        public string AccountNumber { get; set; }
        public int TypeId { get; set; }
        public int CurrencyId { get; set; }
    }
}
