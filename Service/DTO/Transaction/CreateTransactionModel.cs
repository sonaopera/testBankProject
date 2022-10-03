using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.Transaction
{
    public class CreateTransactionModel
    {
        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public int AccountId { get; set; }
        public Core.Models.Transaction MapToTransactionModel { get; internal set; }
    }
}
