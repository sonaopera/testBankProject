using Core.Entities.Enums;
namespace Core.Entities.Document
{
    public class Document
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DocumentType DocumentType { get; set; }
        public string DocumentUrl { get; set; }
    }
}
