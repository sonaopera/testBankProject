using Core.Entities;
using Core.Entities.Document;
using Core.Entities.Enums;

namespace Core.Abstraction.DataAccess
{
    public interface IDocumentRepository
    {
        Document Add(int clinetId, DocumentType documentType, string docUrl);
        void Update(int clinetId, DocumentType documentType, string docUrl);
    }
}
