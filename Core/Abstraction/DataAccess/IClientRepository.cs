using Core.Entities;
using Core.Entities.Client;

namespace Core.Abstraction.DataAccess
{
    public interface IClientRepository
    {
        Client Get(int id);
        PagedData<Client> Get(string firseName, string lastName, int skipCount, int takeCount);
        Client Add(int userId, AddClient client);
        void Update(int id, UpdateClient client);
        void Delete(int id);
    }
}
