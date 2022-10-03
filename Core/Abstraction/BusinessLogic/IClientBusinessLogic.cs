using Core.Entities;
using Core.Entities.Client;

namespace Core.Abstraction.BusinessLogic
{
    public interface IClientBusinessLogic
    {
        Client Get(int id);
        PagedData<Client> Get(string firstName, string lastName, int skipCount, int takeCount);
        Client Add(int userid, AddClient client);
        void Update(int id, UpdateClient client);
        void Delete(int id);
    }
}
