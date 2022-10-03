using Core.Entities;
using Core.Entities.Document;
using Core.Entities.Enums;

namespace Core.Abstraction.BusinessLogic
{
    public interface IDocumentBusinesLogic
    {
        Document Add(int clientId, DocumentType documentType, string docUrl);
        void Update(int clinetId, DocumentType documentType, string docImageBase64);
        string SaveDocumentImage(string docImageBase64);
    }
}
