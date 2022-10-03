using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.Email
{
    public class CreateEmailModel
    {
        public int ClientId { get; set; }
        public string Address { get; set; }
    }
}
