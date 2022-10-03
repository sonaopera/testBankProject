using BLL.DTO.Document;
using BLL.DTO.DocumentType;
using BLL.Interfaces;
using BLL.Mappers;
using Core.Abstraction.DataAccess;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class DocumentTypeService : IDocumentTypeService
    {

        private readonly IDocumentTypeRepository _documentTypeRepo;

        public DocumentTypeService(IDocumentTypeRepository documentTypeRepo)
        {
            _documentTypeRepo = documentTypeRepo;
        }


        public void Add(CreateDocumentTypeModel model)
        {          
            _documentTypeRepo.Add(model.MapToDocumentType());

        }

       

        public void Delete(int id)
        {
            _documentTypeRepo.Delete(id);
        }

        public GetDocumentTypeModel Get(int id)
        {
            return _documentTypeRepo.Get(id).MapToGetDocumentTypeModel();

        }

        public void Update(UpdateDocumentTypeModel model)
        {
            _documentTypeRepo.Update(model.MapToDocumentType());
        }

       
    }



}
