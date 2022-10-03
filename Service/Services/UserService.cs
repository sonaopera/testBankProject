using BLL.DTO.User;
using BLL.Interfaces;
using BLL.Mappers;
using Core.Abstraction.DataAccess;
using Core.Helpers;
using Core.Models;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepo;

        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public void Add(CreatUserModel model)
        {
            model.Password = model.Password.HashSHA1();

            _userRepo.Add(model.MapToUser());
        }

        public void Delete(int id)
        {
            _userRepo.Delete(id);
        }

        public List<GetUserModel> Get(string Name, string Password, DateOnly? CreatedDate, int? EmployeeId, int skipCount, int takeCount)
        {
            return _userRepo.Get(Name, Password, CreatedDate, EmployeeId, skipCount, takeCount).MapToGetUserModel();
        }

        public GetUserModel Get(int id)
        {
            return _userRepo.Get(id).MapToGetUserModel();

        }

        public UserCredentials Get(string userName)
        {
            return _userRepo.Get(userName).MapToUserCredentialsModel();

        }

        public void Update(UpdateUserModel model)
        {
            _userRepo.Update(model.MapToUser());
        }

        public bool IsPasswordMatch(string password, string passwordHash)
        {
            return password.HashSHA1() == passwordHash;
        }
    }

  
}
