using Core.Entities;
using Core.Entities.Client;
using Core.Abstraction.BusinessLogic;
using Core.Abstraction.DataAccess;

namespace BusinessLogicLayer
{
    public class ClientBusinessLogic : IClientBusinessLogic
    {
        private readonly IClientRepository _clientRepository;
        private readonly IDocumentBusinesLogic _documentBusinessLogic;

        public ClientBusinessLogic(IClientRepository clientRepository,
                                   IDocumentBusinesLogic documentBusinessLogic)
        {
            _clientRepository = clientRepository;
            _documentBusinessLogic = documentBusinessLogic;
        }

        public Client Add(int userid, AddClient client)
        {
            var savedClient = _clientRepository.Add(userid, client);

            var docUrl = _documentBusinessLogic.SaveDocumentImage(client.DocumentImageBase64);

            var savedDocument = _documentBusinessLogic.Add(savedClient.Id, client.DocumentType, docUrl);

            savedClient.DocumentType = savedDocument.DocumentType;

            savedDocument.DocumentUrl = savedDocument.DocumentUrl;

            return savedClient;
        }

        public Client Get(int id)
        {
            return _clientRepository.Get(id);
        }

        public PagedData<Client> Get(string firstName, string lastName, int skipCount, int takeCount)
        {
            return _clientRepository.Get(firstName, lastName, skipCount, takeCount);
        }

        public void Update(int id, UpdateClient client)
        {
            _clientRepository.Update(id, client);
        }

        public void Delete(int id)
        {
            _clientRepository.Delete(id);
        }
    }
}
