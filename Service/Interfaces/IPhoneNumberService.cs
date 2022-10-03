using BLL.DTO.PhoneNumber;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IPhoneNumberService 
    {
        void Add(CreatePhoneNumberModel model);
        void Delete(int id);
        void Update(UpdatePhoneNumberModel model);
        List<GetPhoneNumberModel> Get(int? ClientId, int? Numbers, int skipCount , int takeCount );
    }
}
