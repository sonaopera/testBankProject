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
    public class DocumentTypeRepository : BaseRepository<DocumentType>, IDocumentTypeRepository
    {
        protected override string TableName => "DocumentTypeRepository";

        public DocumentTypeRepository(DataAccess dataAccess) : base(dataAccess)
        {
        }


        public override void Add(DocumentType model)
        {

            var query = $@"insert into {TableName} (Names) 
            values({model.Name})";

            dataAccess.RunQuery(query);
        }

       

        protected override DocumentType DataRowToModel(DataRow dr)
        {
            if (dr == null)
            {
                return null;
            }

            return new DocumentType
            {
                Id = dr.Field<int>("id"),
                Name = dr.Field<string>("Names"),



            };
        }

        public override void Update(DocumentType model)
        {
            var query = $@"update {TableName} set Names={model.Name}
            where Id = {model.Id}";
            dataAccess.RunQuery(query);
        }

       
    }
}
