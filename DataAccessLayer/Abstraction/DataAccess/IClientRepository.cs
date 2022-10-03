using Service.Models;

namespace Core.Abstraction.DataAccess
{
    public interface IClientRepository : IBaseRepository<Client>
    {
        List<Client> Get(string firseName, string lastName, int? Age, string Gender, DateTime? CreatedDate, int? CreatedBY, int skipCount = 0, int takeCount = 100);
        
        
    }
}
