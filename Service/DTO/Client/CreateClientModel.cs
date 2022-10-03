using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.Client
{
    public class CreateClientModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBY { get; set; }

        internal Service.Models.Client MapToClientModel()
        {
            throw new NotImplementedException();
        }
    }
}
