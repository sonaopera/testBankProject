using BLL.DTO.Account;
using BLL.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{


    [ApiController]
    [Route("[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class AccountController: ControllerBase
    {
        
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public List<GetAccountModel> Get(string AccountNumber, int? TypeId, decimal? Balances, int? CurrencyId, int skipCount, int takeCount)
        {
            return _accountService.Get(AccountNumber, TypeId, Balances, CurrencyId, skipCount, takeCount);
                
        }

        [HttpPost]
        public void Add(CreateAccountModel model)
        {
            _accountService.Add(model);
        }



        [HttpPut]
        public void Update(UpdateAccountModel model)
        {
            _accountService.Update(model);
        }


        [HttpDelete]
        public void Delete(int Id)
        {
            _accountService.Delete(Id);
        }
    }
   




}