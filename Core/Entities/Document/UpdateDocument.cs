using Core.Entities.Enums;

namespace Core.Entities.Document
{
    public class UpdateDocument
    {
        public DocumentType DocumentType { get; set; }
        public string DocumentImageBase64{ get; set; }
    }
}
