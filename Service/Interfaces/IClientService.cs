using BLL.DTO.Client;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IClientService
    {
        void Add(CreateClientModel model);
        void Delete(int id);
        void Update(UpdateClientModel model);
        GetClientModel Get(int id);
        List<GetClientModel> Get(string firseName, string lastName, int? Age, string Gender, DateTime? CreatedDate, int? CreatedBY, int skipCount, int takeCount);
    } 
}