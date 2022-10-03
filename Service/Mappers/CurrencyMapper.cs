using BLL.DTO.Currency;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public static class CurrencyMapper
    {
        public static Currency MapToCurrency(this CreateCurrencyModel createCurrency)
        {
            return new Currency
            {
                Name = createCurrency.Name,
                

            };
        }

        public static GetCurrencyModel MapToGetCurrencyeModel(this Currency currency)
        {
            return new GetCurrencyModel
            {
                Id = currency.Id,
                Name = currency.Name

            };
        }

        public static Currency MapToCurrency(this UpdateCurrencyModel updateCurrency)
        {
            return new Currency
            {
                Id = updateCurrency.Id,
                Name = updateCurrency.Name
                
            };
        }


    }


}
