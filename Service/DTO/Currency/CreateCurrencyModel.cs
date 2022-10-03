using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.Currency
{
    public class CreateCurrencyModel
    {
        public string Name { get; set; }
        public Core.Models.Currency MapToCarencyModel { get; internal set; }
        public Core.Models.Currency MaptoCarencyModel { get; internal set; }
    }
}
