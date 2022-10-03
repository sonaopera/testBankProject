using System.Data;
using Core.Abstraction.DataAccess;
using Service.Models;

namespace DataAccessLayer.Repositories
{
    public class ClientRepository : BaseRepository<Client>, IClientRepository
    {
        protected override string TableName => "Clients";

        public ClientRepository(DataAccess dataAccess) : base(dataAccess)
        {
        }


        public override void Add(Client model)
        {
            var query = $@"insert into {TableName} (FirstName,LastName,Age,Gender, CreatedDate,CreatedBY ) 
            values('{model.FirstName}',{model.LastName},{model.Age},{model.Gender},{model.CreatedDate},{model.CreatedBY})";

            dataAccess.RunQuery(query);

        }
        public List<Client> Get(string firseName, string lastName, int? Age, string Gender, DateTime? CreatedDate, int? CreatedBY, int skipCount = 0, int takeCount = 100)
        {
            var sqlWhere = new List<string>();

            if (!(Age is null))
            {
                sqlWhere.Add($"Age={Age}");
            }

            if (!(CreatedDate is null))
            {
                sqlWhere.Add($"CreatedDate={CreatedDate}");
            }

            if (!(CreatedBY is null))
            {
                sqlWhere.Add($"CreatedBy={CreatedBY}");
            }

            if (!String.IsNullOrWhiteSpace(firseName))
            {
                sqlWhere.Add($"AccountNumber like '%{firseName}%'");
            }

            if (!String.IsNullOrWhiteSpace(Gender))
            {
                sqlWhere.Add($"AccountNumber like '%{Gender}%'");
            }

            if (!String.IsNullOrWhiteSpace(firseName))
            {
                sqlWhere.Add($"AccountNumber like '%{firseName}%'");
            }

            var query = $@"select * from {TableName} {(sqlWhere.Count > 0 ? $"where {string.Join(" and ", sqlWhere)}" : "")} ORDER BY id OFFSET ({skipCount}) ROWS FETCH NEXT ({takeCount}) ROWS ONLY)";

            return GetByQuery(query).ToList();

        }



       

        protected override Client DataRowToModel(DataRow dr)
        {
            if (dr == null)
            {
                return null;
            }
                        

            return new Client
            {
                Id = dr.Field<int>("id"),
                FirstName = dr.Field<string>("FirstName"),
                LastName = dr.Field<string>("LastName"),
                Age     = dr.Field<int>    ("Age"),
                Gender =  dr.Field<string>("Gender"),
                CreatedDate = dr.Field<DateTime>("tedDate"),
                CreatedBY = dr.Field<int> ("CreatedBY")

            };
        }

        public override void Update(Client model)
        {
            var query = $@"update {TableName} set  Age={model.Age}, CreatedDate={model.CreatedDate}, CreatedBY{model.CreatedBY}
                                                             
                        where Id = {model.Id}";
            dataAccess.RunQuery(query);
        }

        
    }
}
