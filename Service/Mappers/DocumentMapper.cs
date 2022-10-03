using BLL.DTO.Document;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public static class DocumentMapper
    {
        public static Document MapToDocument(this CreateDocumentModel createDocument)
        {
            return new Document
            {
                Types = createDocument.Types,
                Name =createDocument.Name,
                ClientId = createDocument.ClientId,
                Numbers = createDocument.Numbers,

            };
        }
        public static List<GetDocumentModel> MapToGetDocumentModel(this IEnumerable<Document> document)
        {
            return document.Select(x => x.MapToGetDocumentModel()).ToList();

        }

        public static GetDocumentModel MapToGetDocumentModel(this Document document)
        {
            return new GetDocumentModel
            {
                Id = document.Id,
                ClientId = document.ClientId,
                Name = document.Name,
                Numbers = document.Numbers,
                Types = document.Types
            };



        }
        public static Document MapToDocument(this UpdateDocumentModel updateDocument)
        {
            return new Document
            {
                Id = updateDocument.Id,
                ClientId = updateDocument.ClientId,
                Numbers = updateDocument.Numbers,
                Name = updateDocument.Name,
                Types = updateDocument.Types


            };


        }





    }
}
