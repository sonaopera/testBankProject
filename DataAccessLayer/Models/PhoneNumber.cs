using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class PhoneNumber : BaseModel
    {
        public int ClientId { get; set; }
        public int Numbers { get; set; }
       
    }
}
