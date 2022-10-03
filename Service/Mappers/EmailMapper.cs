using BLL.DTO.Email;
using BLL.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL.Mappers
{
    public static  class EmailMapper
    {

        public static Email MapToEmail(this CreateEmailModel createEmail)
        {
            return new Email
            {
               Address = createEmail.Address,
               ClientId = createEmail.ClientId

            };
        }

       

        public static Email MapToEmail(this UpdateEmailModel updateEmail)
        {
            return new Email
            {
               Id =updateEmail.Id,
               Address = updateEmail.Address,
               ClientId = updateEmail.ClientId
               
            };
        }

    }
}
