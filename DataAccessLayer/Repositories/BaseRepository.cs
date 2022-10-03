using Core.Abstraction.DataAccess;
using Core.Models;
using System.Data;

namespace DataAccessLayer.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        protected readonly DataAccess dataAccess;

        public BaseRepository(DataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        protected abstract string TableName { get; }

        protected abstract T DataRowToModel(DataRow dr);

        protected virtual ICollection<T> DataTableToCollection(DataTable dt)
        {
            if (dt == null)
            {
                return null;
            }

            return dt.AsEnumerable().Select(x => DataRowToModel(x)).ToList();
        }

        public abstract void Add(T model);
        public abstract void Update(T model);
        public virtual void Delete(int id)
        {
            var query = $"delete from {TableName} where id={id}";
            dataAccess.RunQuery(query);
        }

        public virtual T Get(int id)
        {
            var query = $"select * from {TableName} where id = {id}";
            //the data access layer is implemented elsewhere
            DataRow dr = dataAccess.SelectDataRow(query);
            return DataRowToModel(dr);
        }

        protected virtual ICollection<T> GetByQuery(string query)
        {
            var dt = dataAccess.SelectDataTable(query);
            return DataTableToCollection(dt);
        }
    }
}
