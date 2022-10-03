using BLL.DTO.AccountType;
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

    public class AccountTypeController : ControllerBase
    {
        private readonly IAccountTypeService _accountTypeService;
        private AccountType model;


        public AccountTypeController(IAccountTypeService accountTypeService)
        {
            _accountTypeService = accountTypeService;
        }


        [HttpPost]
        public void Add(CreateAccountTypeModel model)
        {
            _accountTypeService.Add(model);
        }



        [HttpPut]
        public void Update(UpdateAccountTypeModel model)
        {
            _accountTypeService.Update(model);
        }


        [HttpDelete]
        public void Delete(int id)
        {
            _accountTypeService.Delete(id);
        }

    }

}
