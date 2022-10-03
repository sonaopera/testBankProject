using Core.Entities;
using Core.Entities.User;

namespace Core.Abstraction.BusinessLogic
{
    public interface IUserBusinessLogic
    {
        void Add(AddUser addUser);
        User Get(string userName);
        bool IsPasswordMatch(string password, string passwordHash);
    }
}
