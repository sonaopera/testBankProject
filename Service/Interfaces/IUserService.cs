using BLL.DTO.User;
using BLL.Services;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUserService 
    {
        void Add(CreatUserModel model);
        void Delete(int id);
        void Update(UpdateUserModel model);
        GetUserModel Get(int id);
        UserCredentials Get(string userName);
        bool IsPasswordMatch(string password, string passwordHash);
        List<GetUserModel> Get(string Name, string Password, DateOnly? CreatedDate, int? EmployeeId, int skipCount, int takeCount);
    }
}
