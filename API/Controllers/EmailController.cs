using BLL.DTO.Email;
using BLL.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;
        private Email model;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }


        [HttpPost]
        public void Add(CreateEmailModel model)
        {
            _emailService.Add(model);
        }



        [HttpPut]
        public void Update(UpdateEmailModel model)
        {
            _emailService.Update(model);
        }


        [HttpDelete]
        public void Delete(int id)
        {
            _emailService.Delete(id);
        }

    }
}
