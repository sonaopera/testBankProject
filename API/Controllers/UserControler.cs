using Api.Authentication;
using BLL.DTO.User;
using BLL.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly Authenticator _authenticator;
        private GetUserModel 
            model;

        public UserController(IUserService userService, Authenticator authenticator)
        {
            _userService = userService;
            this._authenticator = authenticator;
        }

        [HttpPost]
        [AllowAnonymous]
        public void Add(CreatUserModel model)
        {
            _userService.Add(model);
        }

        [HttpGet]
        public List<GetUserModel> Get(string Name, string Password, DateOnly? CreatedDate, int? EmployeeId, int skipCount, int takeCount)
        {
            return _userService.Get( Name,  Password,  CreatedDate,  EmployeeId,  skipCount,  takeCount);
        }



        [HttpPut]
        public void Update(UpdateUserModel model)
        {
            _userService.Update(model);
        }


        [HttpDelete]
        public void Delete(int id)
        {
            _userService.Delete(id);
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("login")]
        public string Login([FromBody] Login login)
        {
            return _authenticator.Authenticate(login);
        }
    }
}
