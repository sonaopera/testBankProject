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
    public class PhoneNumberRepository : BaseRepository<PhoneNumber>, IPhoneNumberRepository
    {
        protected override string TableName => "PhoneNumbers";

        public PhoneNumberRepository(DataAccess dataAccess) : base(dataAccess)
        {
        }


        public override void Add(PhoneNumber model)
        {
            var query = $@"insert into {TableName} (ClientId,Numbers ) 
            values({model.ClientId},{model.Numbers})";

            dataAccess.RunQuery(query);

        }

        public List<PhoneNumber> Get(int? ClientId, int? Numbers, int skipCount = 0, int takeCount = 100)
        {
            var sqlWhere = new List<string>();

            if (!(ClientId is null))
            {
                sqlWhere.Add($"ClientId={ClientId}");
            }

            if (!(Numbers is null))
            {
                sqlWhere.Add($"Numbers={Numbers}");
            }

          

            var query = $@"select * from {TableName} {(sqlWhere.Count > 0 ? $"where {string.Join("and", sqlWhere)}" : "")} ORDER BY id OFFSET ({skipCount}) ROWS FETCH NEXT ({takeCount}) ROWS ONLY)";

            return GetByQuery(query).ToList();
        }

        public override void Update(PhoneNumber model)
        {
            var query = $@"upadte {TableName} set ClientId={model.ClientId}, Numbers={model.Numbers} 
            where Id = {model.Id}";
            dataAccess.RunQuery(query);
        }

        protected override PhoneNumber DataRowToModel(DataRow dr)
        {
            if (dr == null)
            {
                return null;
            }

            return new PhoneNumber
            {
                Id = dr.Field<int>("id"),
                ClientId = dr.Field<int>("ClientId"),
                Numbers = dr.Field<int>("Numbers"),
               


            };
        }

       
    }
}
