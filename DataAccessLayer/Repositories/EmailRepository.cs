using Core.Abstraction.DataAccess;
using Core.Models;
using System.Data;

namespace DataAccessLayer.Repositories
{
    public class EmailRepository : BaseRepository<Email>, IEmailRepository
    {     
        public EmailRepository(DataAccess dataAccess) : base(dataAccess)
        {
        }

        protected override string TableName => throw new NotImplementedException();

        public override void Add(Email model)
        {
            var query = $@"insert into {TableName} (ClientId,Address  ) 
            values({model.ClientId},{model.Address})";

            dataAccess.RunQuery(query);
        }

       

        public override void Update(Email model)
        {

            
            var query = $@"upadte {TableName} set ClientId={model.ClientId}, Address={model.Address}
                        where Id = {model.Id}";
            dataAccess.RunQuery(query);
        }

       

        protected override Email DataRowToModel(DataRow dr)
        {
            if (dr == null)
            {
                return null;
            }

            return new Email
            {
                Id = dr.Field<int>("id"),
                ClientId = dr.Field<int>("ClientId"),
                Address = dr.Field<string>("Address"),
               


            };
        }
    }
}
