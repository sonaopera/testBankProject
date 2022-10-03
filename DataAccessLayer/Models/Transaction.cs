using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public  class Transaction : BaseModel
    {
        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public int AccountId { get; set; }
    }
}
