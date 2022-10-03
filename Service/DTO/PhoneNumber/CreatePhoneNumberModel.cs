using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.PhoneNumber
{
    public class CreatePhoneNumberModel
    {
        public int ClientId { get; set; }
        public int Numbers { get; set; }
        public Core.Models.PhoneNumber MapToPhoneNumberModel { get; internal set; }
    }
}
