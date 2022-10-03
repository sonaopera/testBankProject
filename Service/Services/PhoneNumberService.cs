using BLL.DTO.PhoneNumber;
using BLL.Interfaces;
using BLL.Mappers;
using Core.Abstraction.DataAccess;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PhoneNumberService : IPhoneNumberService
    {
        private readonly IPhoneNumberRepository _phoneNumberRepo;

        public PhoneNumberService(IPhoneNumberRepository phoneNumberRepo)
        {
            _phoneNumberRepo = phoneNumberRepo;
        }

        public void Add(CreatePhoneNumberModel model)
        {
            _phoneNumberRepo.Add(model.MapToPhoneNumberModel);
        }

        public void Delete(int id)
        {
            _phoneNumberRepo.Delete(id);
        }

        public List<GetPhoneNumberModel> Get(int? ClientId, int? Numbers, int skipCount, int takeCount)
        {
            return _phoneNumberRepo.Get(ClientId, Numbers, skipCount, takeCount).MapToGetPhoneNumberModel();
        }

        public GetPhoneNumberModel Get(int id)
        {
            return _phoneNumberRepo.Get(id).MapToGetPhoneNumberModel();

        }

        public void Update(UpdatePhoneNumberModel model)
        {
            _phoneNumberRepo.Update(model.MapToPhoneNumber());
        }
    }
}
