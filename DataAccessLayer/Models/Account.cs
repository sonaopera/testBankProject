using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class Account : BaseModel
    {
        public string AccountNumber { get; set; }
        public int TypeId { get; set; }
        public decimal Balances { get; set; }
        public int CurrencyId { get; set; }

       
    }
}
