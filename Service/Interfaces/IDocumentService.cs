using BLL.DTO.Document;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IDocumentService 
    {
        void Add(CreateDocumentModel model);
        void Delete(int id);
        GetDocumentModel Get(int id);
        void Update(UpdateDocumentModel model);
        List <GetDocumentModel> Get(int? Types, int? Numbers, string Name, int? ClientId, int skipCount , int takeCount );

    }
}
