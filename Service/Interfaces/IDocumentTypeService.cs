using BLL.DTO.Document;
using BLL.DTO.DocumentType;
using BLL.Services;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IDocumentTypeService 
    {
        void Add(CreateDocumentTypeModel model);
        void Delete(int id);
        GetDocumentTypeModel Get(int id);
        void Update(UpdateDocumentTypeModel model);
    }

}    
