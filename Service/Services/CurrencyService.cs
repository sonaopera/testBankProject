using BLL.DTO.Currency;
using BLL.Interfaces;
using BLL.Mappers;
using Core.Abstraction.DataAccess;
using Core.Models;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CurrencyService : ICurrencyService
    {

        private readonly ICurrencyRepository _currencyRepo;

        public CurrencyService(ICurrencyRepository currencyeRepo)
        {
            _currencyRepo = currencyeRepo;
        }


        public void Add(CreateCurrencyModel model)
        {
            _currencyRepo.Add(model.MapToCarencyModel);
        }

        public void Delete(int id)
        {
            _currencyRepo.Delete(id);
        }

        public GetCurrencyModel Get(int id)
        {
            return _currencyRepo.Get(id).MapToGetCurrencyeModel();
        }

        public void Update(UpdateCurrencyModel model)
        {
            _currencyRepo.Update(model.MapToCurrency());
        }

       
    }
}
