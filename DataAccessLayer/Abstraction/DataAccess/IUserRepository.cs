using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstraction.DataAccess
{
    public interface IUserRepository : IBaseRepository<User>
    {
        List<User> Get(string Name, string Password, DateOnly? CreatedDate, int? EmployeeId, int skipCount = 0, int takeCount = 100);

        User Get(string userName);
    }
}
