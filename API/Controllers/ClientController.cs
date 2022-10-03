
using BLL.DTO.Client;
using BLL.Interfaces;
using BLL.Mappers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Models;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        private GetClientModel model;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public List<GetClientModel> Get(string firseName, string lastName, int? age, string gender, DateTime? createdDate, int? createdBY, int skipCount, int takeCount)
        {
            return _clientService.Get(firseName, lastName, age, gender, createdDate, createdBY, skipCount, takeCount);
        }



        [HttpPost]
        public void  Add(CreateClientModel model)
        {
            _clientService.Add(model);
        }



        [HttpPut]
        public void Update(UpdateClientModel  model)
        {
            _clientService.Update(model);
        }


        [HttpDelete]
        public void Delete(int id)
        {
            _clientService.Delete(id);
        }


    }


}
