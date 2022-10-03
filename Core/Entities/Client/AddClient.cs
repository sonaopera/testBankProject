using Core.Entities.Enums;

namespace Core.Entities.Client
{
    public class AddClient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DocumentType DocumentType { get; set; }
        public string DocumentImageBase64 { get; set; }
    }
}
