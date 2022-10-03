using Core.Entities;
using Core.Abstraction.BusinessLogic;
using Core.Entities.Enums;
using Core.Abstraction.DataAccess;
using Core.Entities.Document;

namespace BusinessLogicLayer
{
    public class DocumentBusinessLogic : IDocumentBusinesLogic
    {
        private readonly IDocumentRepository documentRepository;

        public DocumentBusinessLogic(IDocumentRepository documentRepository)
        {
            this.documentRepository = documentRepository;
        }

        public Document Add(int clientId, DocumentType documentType, string docUrl)
        {
            return documentRepository.Add(clientId, documentType, docUrl);
        }

        public void Update(int clinetId, DocumentType documentType, string docImageBase64)
        {
            var docUrl = SaveDocumentImage(docImageBase64);

            documentRepository.Update(clinetId, documentType, docUrl);
        }

        public string SaveDocumentImage(string docImageBase64)
        {
            return "";
        }
    }
}
