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
    public class CurrencyRepository : BaseRepository<Currency>, ICurrencyRepository
    {
        protected override string TableName => "Currency";

        public CurrencyRepository(DataAccess dataAccess) : base(dataAccess)
        {
        }


        public override void Add(Currency model)
        {


            var query = $@"insert into {TableName} (Names) 
            values({model.Name})";

            dataAccess.RunQuery(query);

        }



        
        protected override Currency DataRowToModel(DataRow dr)
        {
            if (dr == null)
            {
                return null;
            }

            return new Currency
            {
                Id = dr.Field<int>("id"),
                Name = dr.Field<string>("Name"),



            };
        }

       
        public override void Update(Currency model)
        {
            var query = $@"update {TableName} set Names={model.Name}
            where Id = {model.Id}";
            dataAccess.RunQuery(query);
        }
    }
        
    
}
