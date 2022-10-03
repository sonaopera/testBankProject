using BLL.DTO.DocumentType;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public static class DocumentTypeMapper
    {
        public static DocumentType MapToDocumentType(this CreateDocumentTypeModel createDocumentType)
        {
            return new DocumentType
            {
               Name = createDocumentType.Name
            };
        }

        public static GetDocumentTypeModel MapToGetDocumentTypeModel(this DocumentType documentType)
        {
            return new GetDocumentTypeModel
            {  
                Id= documentType.Id,
                Name = documentType.Name

            };
        }
        public static DocumentType MapToDocumentType(this UpdateDocumentTypeModel updateDocumentType)
        {
            return new DocumentType
            {   
                Id= updateDocumentType.Id,
                Name = updateDocumentType.Name
            };
        }

    }
}
