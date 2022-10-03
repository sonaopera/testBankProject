using BLL.DTO.PhoneNumber;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public static class PhoneNumberMapper
    {
        public static PhoneNumber MapToPhoneNumber(this CreatePhoneNumberModel createPhoneNumber)
        {
            return new PhoneNumber
            {
                Numbers = createPhoneNumber.Numbers,
                ClientId = createPhoneNumber.ClientId
                

            };
        }
        public static List<GetPhoneNumberModel> MapToGetPhoneNumberModel(this IEnumerable<PhoneNumber> phoneNumber)
        {
            return phoneNumber.Select(x => x.MapToGetPhoneNumberModel()).ToList();

        }

        public static GetPhoneNumberModel MapToGetPhoneNumberModel(this PhoneNumber phoneNumber)
        {
            return new GetPhoneNumberModel
            {
               Id = phoneNumber.Id,
               ClientId = phoneNumber.ClientId,
               Numbers = phoneNumber.Numbers
               
            };



        }

        public static PhoneNumber MapToPhoneNumber(this UpdatePhoneNumberModel updatePhoneNumber)
        {
            return new PhoneNumber
            {
                Id = updatePhoneNumber.Id,
                ClientId = updatePhoneNumber.ClientId,
                Numbers = updatePhoneNumber.Numbers



            };


        }



    }
}
