using BLL.DTO.PhoneNumber;
using BLL.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PhoneNumberController : ControllerBase
    {
        private readonly IPhoneNumberService _phoneNumberService;

        public PhoneNumberController(IPhoneNumberService phoneNumberService)
        {
            _phoneNumberService = phoneNumberService;
        }


        [HttpGet]
        public  List<GetPhoneNumberModel> Get(int? ClientId, int? Numbers, int skipCount, int takeCount)
        {
            return _phoneNumberService.Get( ClientId,  Numbers,  skipCount,  takeCount);
        }


        

        [HttpPost]
        public void Add(CreatePhoneNumberModel model)
        {
            _phoneNumberService.Add(model);
        }



        [HttpPut]
        public void Update(UpdatePhoneNumberModel model)
        {
            _phoneNumberService.Update(model);
        }


        [HttpDelete]
        public void Delete(int id)
        {
            _phoneNumberService.Delete(id);
        }



    }
}
