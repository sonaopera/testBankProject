using Core.Entities;
using Core.Entities.User;

namespace Core.Abstraction.DataAccess
{
    public interface IUserRepository
    {
        void Add(string username, string password);
        User Get(string username);
    }
}
