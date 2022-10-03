using BLL.DTO.Client;
using BLL.Interfaces;
using BLL.Mappers;
using Core.Abstraction.DataAccess;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services

{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepo;

        private readonly List<string> _genders = new List<string>
        {
            "Male",
            "Female",
            "Other"
        };

        public ClientService(IClientRepository clientRepo)
        {
            _clientRepo = clientRepo;
        }

        


        public void Add(CreateClientModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            if (string.IsNullOrEmpty(model.Gender) || !_genders.Contains(model.Gender))
            {
                throw new ArgumentException(nameof(model.Gender));
            }

            _clientRepo.Add(model.MapToClientModel());


        }

        public void Delete(int id)
        {
            _clientRepo.Delete(id);
        }


        public void Update(UpdateClientModel model)
        {
            _clientRepo.Update(model.MapToClient()) ;

        }

      
        public GetClientModel Get(int id)
        {
            return _clientRepo.Get(id).MapToGetClientModel();


        }
        public List<GetClientModel> Get(string firseName, string lastName, int? Age, string Gender, DateTime? CreatedDate, int? CreatedBY, int skipCount, int takeCount)
        {
            return _clientRepo.Get(firseName, lastName, Age, Gender, CreatedDate, CreatedBY, skipCount, takeCount).MapToGetClientModel();

        }

       
    }
}
