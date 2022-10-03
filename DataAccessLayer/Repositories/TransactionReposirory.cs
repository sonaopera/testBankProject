
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
    public class TransactionReposirory : BaseRepository<Transaction>, ITransactionRepository
    {
        protected override string TableName => "Transaction";

        public TransactionReposirory(DataAccess dataAccess) : base(dataAccess)
        {
        }


        public override void Add(Transaction model)
        {
            var query = $@"insert into {TableName} (Dates,Amouts,AccountId, ) 
            values({model.Date},{model.Amount},{model.AccountId})";

            dataAccess.RunQuery(query);
        }

        public List<Transaction> Get(DateOnly? Dates, decimal? Amouts, int? AccountId, int skipCount = 0, int takeCount = 100)
        {
            var sqlWhere = new List<string>();

            if (!(Dates is null))
            {
                sqlWhere.Add($"Dates={Dates}");
            }

            if (!(Amouts is null))
            {
                sqlWhere.Add($"Amouts={Amouts}");
            }

            if (!(AccountId is null))
            {
                sqlWhere.Add($"AccountId={AccountId}");
            }

            

            var query = $@"select * from {TableName} {(sqlWhere.Count > 0 ? $"where {string.Join("and", sqlWhere)}" : "")} ORDER BY id OFFSET ({skipCount}) ROWS FETCH NEXT ({takeCount}) ROWS ONLY)";

            return GetByQuery(query).ToList();
        }

       

        protected override Transaction DataRowToModel(DataRow dr)
        {

            if (dr == null)
            {
                return null;
            }

            return new Transaction
            {
                Id = dr.Field<int>("id"),
                Date = dr.Field<DateTime>("Dates"),
                Amount = dr.Field<decimal>("Amouts"),
                AccountId = dr.Field<int>("AccountId"),
               


            };
        }

       

        public override void Update(Transaction model)
        {
            var query = $@"upadte {TableName} set Dates={model.Date}, Amouts={model.Amount} AccountId={model.AccountId},       
           
            where Id = {model.Id}";

            dataAccess.RunQuery(query);
        }
    }
}
