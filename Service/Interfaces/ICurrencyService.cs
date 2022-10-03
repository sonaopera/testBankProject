using BLL.DTO.Currency;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ICurrencyService 
    {
        void Add(CreateCurrencyModel model);
        void Delete(int id);
        void Update(UpdateCurrencyModel model);
      
    }
}
