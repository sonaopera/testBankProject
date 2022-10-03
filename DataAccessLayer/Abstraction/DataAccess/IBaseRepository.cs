using Core.Models;
namespace Core.Abstraction.DataAccess
{
    public interface IBaseRepository<T> where T : BaseModel
    {
        T Get(int id);
        void Add(T model);
        void Delete(int id);
        void Update(T model);
    }
}
