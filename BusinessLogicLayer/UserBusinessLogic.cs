using Core.Abstraction.BusinessLogic;
using Core.Abstraction.DataAccess;
using Core.Helpers;
using Core.Entities.User;

namespace BusinessLogicLayer
{
    public class UserBusinessLogic : IUserBusinessLogic
    {
        private readonly IUserRepository userRepository;

        public UserBusinessLogic(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void Add(AddUser user)
        {
            var passwordHash = user.Password.HashSHA1();

            userRepository.Add(user.UserName, passwordHash);
        }

        public User Get(string userName)
        {
            return userRepository.Get(userName);
        }

        public bool IsPasswordMatch(string password, string passwordHash)
        {
            return password.HashSHA1() == passwordHash;
        }
    }
}
