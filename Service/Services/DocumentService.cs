using BLL.DTO.Document;
using BLL.Interfaces;
using BLL.Mappers;
using Core.Abstraction.DataAccess;

namespace BLL.Services
{
    public class DocumentService : IDocumentService
    {

        private readonly IDocumentRepository _documentRepo;

        public DocumentService(IDocumentRepository documentRepo)
        {
            _documentRepo = documentRepo;
        }


        public void Add(CreateDocumentModel model)
        {
            _documentRepo.Add(model.MapToDocumentTypeModel());

        }

        public void Delete(int id)
        {
            _documentRepo.Delete(id);
        }

        public GetDocumentModel Get(int id)
        {
            return _documentRepo.Get(id).MapToGetDocumentModel();

        }

        public List<GetDocumentModel> Get(int? Types, int? Numbers, string Name, int? ClientId, int skipCount, int takeCount)
        {
            return _documentRepo.Get(Types, Numbers, Name, ClientId, skipCount, takeCount).MapToGetDocumentModel();
        }

        public void Update(UpdateDocumentModel model)
        {
            _documentRepo.Update(model.MapToDocument());
        }
    }
}
