using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstraction.DataAccess
{
    public interface IPhoneNumberRepository : IBaseRepository<PhoneNumber>
    {
        List <PhoneNumber> Get(int? ClientId, int? Numbers, int skipCount = 0, int takeCount = 100);
        
    }
}
