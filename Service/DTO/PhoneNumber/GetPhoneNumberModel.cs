using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.PhoneNumber
{
    public class GetPhoneNumberModel
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int Numbers { get; set; }

    }
}
