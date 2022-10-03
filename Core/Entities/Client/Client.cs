using Core.Entities.Enums;

namespace Core.Entities.Client
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DocumentType DocumentType { get; set; }
        public string DocumentUrl { get; set; }
        public int CreatedBy { get; set; }
    }
}
