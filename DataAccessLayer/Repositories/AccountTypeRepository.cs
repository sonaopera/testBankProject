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
    public class AccountTypeRepository : BaseRepository<AccountType>, IAccountTypeRepository
    {
        protected override string TableName => "AccountType";

        public AccountTypeRepository(DataAccess dataAccess) : base(dataAccess)
        {
        }


        public override void Add(AccountType model)
        {

            var query = $@"insert into {TableName} (Name) 
            values({model.Names})";

            dataAccess.RunQuery(query);
        }

       

        protected override AccountType DataRowToModel(DataRow dr)
        {
            if (dr == null)
            {
                return null;
            }

            return new AccountType
            {
                Id = dr.Field<int>("Id"),
                Names = dr.Field<string>("Name"),



            };
        }

        public override void Update(AccountType model)
        {
          
            var query = $@"upadte {TableName} set Names={model.Names}
                         where Id = {model.Id}";
            dataAccess.RunQuery(query);
        }
    }
    
}
