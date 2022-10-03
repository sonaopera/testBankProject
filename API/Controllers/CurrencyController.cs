
using BLL.DTO.Currency;
using BLL.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class CurrencyController: ControllerBase
    {
        private readonly ICurrencyService _currencieService;
        private Currency model;

        public CurrencyController(ICurrencyService currencieService)
        {
            _currencieService = currencieService;
        }


        [HttpPost]
        public void Add(CreateCurrencyModel model)
        {
            _currencieService.Add(model);
        }



        [HttpPut]
        public void Update(UpdateCurrencyModel model)
        {
            _currencieService.Update(model);
        }


        [HttpDelete]
        public void Delete(int id)
        {
            _currencieService.Delete(id);
        }

      
    }
}
