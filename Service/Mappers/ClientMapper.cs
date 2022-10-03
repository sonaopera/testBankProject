using BLL.DTO.Client;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public static class ClientMapper
    {
        public static Client MapToClient(this CreateClientModel createClient)
        {
            return new Client
            {
                FirstName = createClient.FirstName,
                LastName = createClient.LastName,
                Gender = createClient.Gender,
                Age = createClient.Age,
                CreatedDate = createClient.CreatedDate,
                CreatedBY = createClient.CreatedBY,
            };
        }
        public static List<GetClientModel> MapToGetClientModel(this IEnumerable<Client> client)
        {
            return client.Select(x => x.MapToGetClientModel()).ToList();

        }

        public static GetClientModel MapToGetClientModel(this Client client)
        {
            return new GetClientModel
            {
                Id = client.Id,
                FirstName = client.FirstName,
                Age = client.Age,
                CreatedBY = client.CreatedBY,
                CreatedDate = client.CreatedDate,
                LastName = client.LastName,
                Gender = client.Gender,
                




            };
            
        }
        public static Client MapToClient(this UpdateClientModel updateClient)
        {
            return new Client
            {
               Id = updateClient.Id,
               Age = updateClient.Age,
               CreatedDate = updateClient.CreatedDate,
               FirstName = updateClient.FirstName,
               LastName = updateClient.LastName,
               Gender = updateClient.Gender,
               CreatedBY = updateClient.CreatedBY,
               



            };


        }
    }
   

}
