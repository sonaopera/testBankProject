using Core.Abstraction.DataAccess;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class AccountRepository : BaseRepository<Account>, IAccountRepository
    {
        private object balances;

        protected override string TableName => "Accounts";

        public AccountRepository(DataAccess dataAccess) : base(dataAccess)
        {
        }

        public override void Add(Account model)
        {
            var query = $@"insert into {TableName} (AccountNumber,TypeId,Balances,CurrencyId ) 
            values({model.AccountNumber},{model.TypeId},{model.Balances},{model.CurrencyId})";

            dataAccess.RunQuery(query);
        }

        public List<Account> Get(string AccountNumber, int? TypeId, decimal? Balances, int? CurrencyId, int skipCount = 0, int takeCount = 100)
        {
            var sqlWhere = new List<string>();

            if (!(TypeId is null))
            {
                sqlWhere.Add($"TypeId={TypeId}");
            }

            if (!(Balances is null))
            {
                sqlWhere.Add($"Balances={Balances}");
            }

            if (!(CurrencyId is null))
            {
                sqlWhere.Add($"CurrencyId={CurrencyId}");
            }

            if (!String.IsNullOrWhiteSpace(AccountNumber))
            {
                sqlWhere.Add($"AccountNumber like '%{AccountNumber}%'");
            }

            var query = $@"select * from {TableName} {(sqlWhere.Count > 0 ? $"where {string.Join("and", sqlWhere)}" : "")} ORDER BY id OFFSET ({skipCount}) ROWS FETCH NEXT ({takeCount}) ROWS ONLY";

            return GetByQuery(query).ToList();
        }

        public override void Update(Account model)
        {
            
            var query = $@"upadte {TableName} set  AccountNumber={model.AccountNumber}, TypeId={model.TypeId},Balances = {model.Balances},CurrencyId = {model.CurrencyId}
                           where Id = {model.Id}";
            dataAccess.RunQuery(query);
        }

        protected override Account DataRowToModel(DataRow dr)
        {

            if (dr == null)
            {
                return null;
            }

            return new Account
            {
                Id = dr.Field<int>("id"),
                AccountNumber = dr.Field<string>("AccountNumber"),
                TypeId = dr.Field<int>("TypeId"),
                Balances = dr.Field<decimal>("Balances"),
                CurrencyId = dr.Field<int>("CurrencyId "),


            };
        }


       
    }
}
