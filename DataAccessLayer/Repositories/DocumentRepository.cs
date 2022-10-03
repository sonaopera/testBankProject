using Core.Abstraction.DataAccess;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class DocumentRepository : BaseRepository<Document>, IDocumentRepository
    {
        protected override string TableName => "Documents";

        public DocumentRepository(DataAccess dataAccess) : base(dataAccess)
        {
        }


        public override void Add(Document model)
        {
            var query = $@"insert into {TableName} (Types,Numbers,Name, ClientId,CreatedBY ) 
            values({model.Types},{model.Numbers},{model.Name},{model.ClientId})";

            dataAccess.RunQuery(query);
        }

        public List<Document> Get(int? Types, int? Numbers, string Name, int? ClientId, int skipCount = 0, int takeCount = 100)
        {

            var sqlWhere = new List<string>();

            if (!(Types is null))
            {
                sqlWhere.Add($"Types={Types}");
            }

            if (!(Numbers is null))
            {
                sqlWhere.Add($"Numbers={Numbers}");
            }

            if (!(ClientId is null))
            {
                sqlWhere.Add($"ClientId={ClientId}");
            }

            if (!String.IsNullOrWhiteSpace(Name))
            {
                sqlWhere.Add($"Name like '%{Name}%'");
            }

            var query = $@"select * from {TableName} {(sqlWhere.Count > 0 ? $"where {string.Join("and", sqlWhere)}" : "")} ORDER BY id OFFSET ({skipCount}) ROWS FETCH NEXT ({takeCount}) ROWS ONLY)";

            return GetByQuery(query).ToList();
        }

        public override void Update(Document model)
        {
            var query = $@"upadte {TableName} set Types ={model.Types}, Numbers={model.Numbers} Name={model.Name},
             ClientId = {model.ClientId},
            where Id = {model.Id}";
            dataAccess.RunQuery(query);



        }
        protected override Document DataRowToModel(DataRow dr)
        {
            if (dr == null)
            {
                return null;
            }

            return new Document
            {
                Id = dr.Field<int>("id"),
                Types = dr.Field<int>("Types"),
                Numbers = dr.Field<int>("Numbers"),
                Name = dr.Field<string>("Name"),
                ClientId = dr.Field<int>("ClientId"),



            };
            
           

        }


    }
}
